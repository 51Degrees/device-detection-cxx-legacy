all: libapr Release apr-skeleton

libapr:
	make -C ./apr/ all
	

apr-skeleton: apr-skeleton.c 
	gcc apr-skeleton.c -o apr-skeleton -I./apr/apr-build/include/apr-1 -I./apr/aprutil-build/include/apr-1 -L./apr/lib/ -lapr-1 -Wl,-Bdynamic -lpthread -lc -D_REENTRANT -D_GNU_SOURCE -D_LARGEFILE64_SOURCE
#	gcc apr-skeleton.c -o apr-skeleton -I./apr/apr-build/include/apr-1 -I./apr/aprutil-build/include/apr-1 -L./apr/lib/ -lapr-1 -lpthread -D_REENTRANT -D_GNU_SOURCE -D_LARGEFILE64_SOURCE

Debug: ab.c ap_release.h
	gcc -g ab.c ap_release.h -o ab -I./apr/apr-build/include/apr-1 -I./apr/aprutil-build/include/apr-1 -L./apr/lib/ -L./apr/apr/aprutil-build/lib/ -lapr-1 -laprutil-1 -Wl,-Bdynamic -lm -lc -lpthread -D_REENTRANT -D_GNU_SOURCE -D_LARGEFILE64_SOURCE
#	gcc ab.c ap_release.h -o ab -I./apr/apr-build/include/apr-1 -I./apr/aprutil-build/include/apr-1 -L./apr/lib/ -L./apr/apr/aprutil-build/lib/ -lapr-1 -laprutil-1 -lm  -lpthread -D_REENTRANT -D_GNU_SOURCE -D_LARGEFILE64_SOURCE

Release: ab.c ap_release.h
	gcc ab.c ap_release.h -o ab -I./apr/apr-build/include/apr-1 -I./apr/aprutil-build/include/apr-1 -L./apr/lib/ -L./apr/apr/aprutil-build/lib/ -lapr-1 -laprutil-1 -Wl,-Bdynamic -lm -lc -lpthread -D_REENTRANT -D_GNU_SOURCE -D_LARGEFILE64_SOURCE
#	gcc ab.c ap_release.h -o ab -I./apr/apr-build/include/apr-1 -I./apr/aprutil-build/include/apr-1 -L./apr/lib/ -L./apr/apr/aprutil-build/lib/ -lapr-1 -laprutil-1 -lm  -lpthread -D_REENTRANT -D_GNU_SOURCE -D_LARGEFILE64_SOURCE



clean:
	make -C ./apr/ clean
	rm ab apr-skeleton
