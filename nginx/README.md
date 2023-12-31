![51Degrees](https://51degrees.com/DesktopModules/FiftyOne/Distributor/Logo.ashx?utm_source=github&utm_medium=repository&utm_content=readme_main&utm_campaign=nginx-open-source "THE Fastest and Most Accurate Device Detection") **Device Detection in C** Nginx module

[Supported Databases](https://51degrees.com/compare-data-options?utm_source=github&utm_medium=repository&utm_content=compare-data-options&utm_campaign=nginx-open-source "Different device databases which can be used with 51Degrees device detection") | [Developer Documention](https://51degrees.com/support/documentation?utm_source=github&utm_medium=repository&utm_content=documentation&utm_campaign=nginx-open-source "Full getting started guide and advanced developer documentation") | [Available Properties](https://51degrees.com/resources/property-dictionary?utm_source=github&utm_medium=repository&utm_content=property_dictionary&utm_campaign=nginx-open-source "View all available properties and values")

<sup>Need [.NET](https://github.com/51Degrees/.NET-Device-Detection "THE Fastest and most Accurate device detection for .NET") | [Java](https://github.com/51Degrees/Java-Device-Detection "THE Fastest and most Accurate device detection for Java") | [PHP Script](https://github.com/51Degrees/51Degrees-PHP)?</sup>

The NGINX module is currently in beta. Any bugs reported will be added to the stable release.

## Introduction

In nginx.config, use like...
```nginx
http {
  51D_filePath path/to/51Degrees.dat;
  server {
    ...
    location / {
      51D_match_all X-Mobile IsMobile;
      ...
    }
  }
}
```
... to turn User-Agent HTTP headers into useful information about physical screen size, device price and type of device.

Use this project to detect device properties using HTTP browser User-Agents as input using the patented pattern detection method.

Two detection methods are supported.

**Pattern:**  Searches for device signatures in a useragent returning metrics about the validity of the results. Does NOT use regular expressions.

**Trie:** A large binary Trie (pronounced Try) populated with User-Agent signatures. Very fast.

All methods use an external data file which can easilly be updated.

## Dependencies
- gcc
- make
- Nginx source
##### Test Dependencies
- curl
- grep
- ApacheBench dependencies (see Device-Detection/ApacheBench/README.md)

For Ubuntu based distributions gcc can be found on apt, use
```
$ sudo apt-get install gcc make
```
and the Nginx source will be automatically downloaded by the make file.

## Install
<installation>
### Linux
#### Test Installation
This is the quickest and easiest way to build Nginx in a local directory to try out the module. Just use
```
$ git clone https://github.com/51Degrees/Device-Detection.git
$ cd Device-Detection/nginx
$ make install pattern
```
or 
```
$ make install trie
```
To install to the local directory.

Then run the included tests with:
```
$ make test
```
which will all pass if the local installation was successful.

**Note: If ApacheBench tests fail even though the dependencies are fulfilled it may need to be recompiled using the correct compiler for your OS. This can be done using Device-Detection/CodeBlocks/ApacheBench.cbp**

#### For an existing Nginx deployment
##### Static Module
To compile the module into an existing Nginx deployment,
first clone 51Degrees/Device-Detection repository with
```
$ git clone https://github.com/51Degrees/Device-Detection.git
```
Move to the Nginx directory with
```
$ cd Device-Detection/nginx
```
and put together the module directory with either
```
$ make build pattern
```
or
```
$ make build trie
```
Copy the module to the Nginx modules directory with
```
$ cp -r 51Degrees_module [MODULE DIRECTORY]
```
In the Nginx source directory, run ``./configure`` as normal and add the module, the linker option ``-lm`` and the definitions ``FIFTYONEDEGREES_PATTERN`` and ``FIFTYONEDEGREES_NO_THREADING`` (or ``FIFTYONEDEGREES_TRIE`` for the Trie module). A basic example is,
```
$ ./configure \
    --prefix=[NGINX INSTALL DIRECTORY] \
    --with-ld-opt="-lm" \
    --with-cc-opt="-DFIFTYONEDEGREES_PATTERN -DFIFTYONEDEGREES_NO_THREADING"
    --add-module=[MODULE DIRECTORY]/51Degrees_module
```
**Note: with Pattern the arguments ``-Wno-ignored-qualifiers -Wno-unused-result`` are also needed.**

Then install with
```
$ sudo make install
```
##### Dynamic Module
51Degrees can also be build as a dynamic module for Nginx version 1.9 or later.

To build the module as ngx_http_51D_module.so, follow the same instructions as the static build above, but replace the ``add_module`` argument with ``add_dynamic_module``. By default, the module will be built to Nginx's module directory. The only extra thing which will need to be added to the config file is the line
```
load_module modules/ngx_http_51D_module.so;
```
**Note: Nginx insists on the same compile arguments being used in both the Nginx executable and the dynamic module.**
</installation>
## Configure
<configuration>
Before start matching user agents, you may wish to configure the solution to use a different database for example.
### Settings
#### General Settings
These settings are valid in the main configuration block and should only be set once.
 - ``51D_filePath`` (defaults to ``'51Degrees.dat'``). Sets the location of the data file.

 - ``51D_cache`` (defaults to ``0``). Sets the size of the workset cache.
 
 - ``51D_valueSeparator`` (defaults to ``','``). Sets the delimiter to separate values with.

#### Location Settings
These settings are valid in a location configuration block and should only be set once per location.
 - ``51D_match_single`` (defaults to disabled). Gets device properties using a User-Agent. Takes the name the resultant header will be set as, and a comma separated list of properties to return.

 - ``51D_match_all`` (defaults to disabled). Gets device properties using multiple HTTP headers. Takes the name the resultant header will be set as, and a comma separated list of properties to return.

## Usage
### The Config File
An example configuration file is included in this repository. It shows how to pass device information when using Nginx as a reverse proxy, and when passing to a fast-cgi provider.
#### HTTP Block
Within the HTTP block is where the detector settings are set, these should be set like
```
http {
  51D_filePath data/51Degrees.dat;
  51D_cache 10000;
  ...
}
```
#### Location Block
Within a location block is where the match settings are set. They can be set in one of two ways:
##### User-Agent match
To get properties using the device's User-Agent use:
```
location / {
  51D_match_single x-user-agent-match HardwareName,DeviceType,BrowserName;
  ...
}
```
##### Multiple HTTP header matches
To get properties from all the relevant HTTP headers from the device use:
```
location / {
  51D_match_all x-all-headers-match HardwareName,BrowserName,PlatformName;
  ...
}
```
##### Proxy Passing
When using the ``proxy_pass`` directive in a location block where a match directive is used, the properties selected are passed as additional HTTP headers with the name specified in the first argument of ``51D_match_single``/``51D_match_all``.
##### Fast-CGI
Using ``include fastcgi_params;`` makes these additional headers available via the ``$_SERVER`` variable.

##### Output Format
The value of the header is set to a comma separated list of values (comma delimited is the default behaviour, but the delimiter can be set explicitly with ``51D_valueSeparator``), these are in the same order the properties are listed in the config file. So setting a header with the line:
```
51D_match_all x-device HardwareName,BrowserName,PlatformName;
```
will give a header named ``x-device`` with a value like ``Desktop,Firefox,Ubuntu``. Alternatively, headers can be set individually like:
```
51D_match_all x-hardware HardwareName;
51D_match_all x-browser BrowserName;
51D_match_all x-platform PlatformName;
```
giving three seperate headers.

### Example
If installing to a local directory using ``make install pattern``/``make install trie``, the executable is set up to use the example configuration and can be easily tested. Take ``example.php``, which just prints all request headers, and place it in apache's web directory (probably /var/www/html).
Now, once Nginx is started by running
```
$ ./nginx
```
in the ``Device-Detection/nginx`` directory, accessing ``localhost:8888/example.php`` will display all request headers which will include the device properties:
```
x-device: Desktop,Firefox,Ubuntu
x-tablet: False
x-smartphone: False
x-metrics: 15364-18118-57666-18092,Exact,0,1538 
```
Alternatively, the line ``add_header x-mobile http_x_mobile`` is included in the example config. This adds the header to the response headers, so can be viewed in the response without a PHP server set up. In a Linux environment, these can be viewed with the command:
```
$ curl localhost:8888 -I -A [SOME USER-AGENT]
```
which will give the following response:
```
HTTP/1.1 200 OK
Server: nginx/1.10.0
...
x-device: Desktop,Firefox,Windows
x-mobile: False
x-tablet: False
x-smartphone: False
x-metrics: 15364-21460-53251-18092,Exact,0,249
```
