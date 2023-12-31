<?php
/*
This Source Code Form is copyright of 51Degrees Mobile Experts Limited.
Copyright (c) 2015 51Degrees Mobile Experts Limited, 5 Charlotte Close,
Caversham, Reading, Berkshire, United Kingdom RG4 7BY

This Source Code Form is the subject of the following patent
applications, owned by 51Degrees Mobile Experts Limited of 5 Charlotte
Close, Caversham, Reading, Berkshire, United Kingdom RG4 7BY:
European Patent Application No. 13192291.6; and
United States Patent Application Nos. 14/085,223 and 14/085,301.

This Source Code Form is subject to the terms of the Mozilla Public
License, v. 2.0.

If a copy of the MPL was not distributed with this file, You can obtain
one at http://mozilla.org/MPL/2.0/.

This Source Code Form is "Incompatible With Secondary Licenses", as
defined by the Mozilla Public License, v. 2.0.
*/

/*
<tutorial>
Offline processing example of using 51Degrees device detection. The example
shows how to:
<ol>
<li>Fetch a pointer to the 51Degrees device detection provider instance.
This is instantiated on server startup and uses settings from php.ini.
<p><pre class="prettyprint lang-php">
$provider = FiftyOneDegreesTrieV3::provider_get();
</pre></p>
<li>Open an input file with a list of User-Agents, and an output file. The
output folder must be in the same directory as this page and have write
permissions.
<p><pre class="prettyprint lang-php">
$file_in = fopen("20000 User Agents.csv", "r");
$file_out = fopen($outputFolder."/".$outputFile, "w");
</pre></p>
<li>Write a header to the output file with the property names in '|'
separated CSV format ('|' separated because some User-Agents contain
commas)
<p><pre class="prettyprint lang-php">
fwrite($file_out, "User-Agent");
foreach ($properties as $property) {
	fwrite($file_out, "|".$property);
}
fwrite($file_out, "\n");
</pre></p>
<li>For the first 20 User-Agents in the input file, perform a match then
write the User-Agent along with the values for chosen properties to
the CSV.
<p><pre class="prettyprint lang-php">
while( my $userAgent = <$file_in>) {
	chomp $userAgent;
	my $match = $provider->getMatch($userAgent);
	print file_out $userAgent;
	foreach $property (@$properties) {
		print file_out "|".$match->getValue($property);
	}
	print file_out "\n";
	last if $. == 20;
}
</pre></p>
</ol>
This example assumes you have the 51Degrees PHP API installed correctly,
and have FiftyOneDegreesTrieV3.php and "20000 User Agents.csv"
in this directory. The output directory must also exist and have
write permissions.
</tutorial>
*/
// Snippet Start
require("../trie/FiftyOneDegreesTrieV3.php");

/*
Initialises the device detection provider with settings from php.ini.
A Lite data file is included. For more info see:
<a href="https://51degrees.com/compare-data-options">compare data options
</a>
*/

$provider = FiftyOneDegreesTrieV3::provider_get();

$inputFile = "20000 User Agents.csv";
$outputFile = "offlineProcessingOutput.csv";
$outputFolder = "output";

// Fetches an array of properties from the php.ini file.

$iniProperties = ini_get('FiftyOneDegreesTrieV3.property_list');
$properties = explode(",", $iniProperties);

echo "Starting Offline Processing.<br>\n";

// Opens input and output files, writes a header to the output file containing
// the column titles. Then reads the first 20 User-Agents from the input
// file, runs a match for each and writes results to the output file.

$file_in = fopen($inputFile, "r");
$file_out = fopen($outputFolder."/".$outputFile, "w");

fwrite($file_out, "User-Agent");
foreach ($properties as $property) {
	fwrite($file_out, "|".$property);
}
fwrite($file_out, "\n");

for ($i=0;$i<20;$i++) {
	$userAgent = trim(fgets($file_in), "\n");
	$match = $provider->getMatch($userAgent);
	fwrite($file_out, $userAgent);
	foreach ($properties as $property) {
		fwrite($file_out, "|".$match->getValue($property));
	}
	fwrite($file_out, "\n");
}
fclose($file_in);
fclose($file_out);

echo "Output Written to ".getcwd()."/".$outputFolder."/".$outputFile;
//Snipped End
?>
