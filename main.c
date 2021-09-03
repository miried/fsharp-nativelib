#include <stdio.h>
#include <dlfcn.h>

int main(int argc, char** argv)
{
    void *handle;
	int (*add)(int a, int b);
	int (*write_line)(const char *pStr);

	handle = dlopen("./bin/release/net5.0/linux-x64/native/fslib.so", RTLD_LAZY);

	add = dlsym(handle, "add");
	int result = add(1, 2);

	printf( "result %i\n", result );

	write_line = dlsym(handle, "write_line");

	write_line("asd");
}
