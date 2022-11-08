#include "tchar.h"
#include<winsock2.h>
#pragma comment(lib,"ws2_32.lib")
#include<Windows.h>
#include<iostream>

using namespace std;
DWORD WINAPI ThreadFunc(LPVOID client_socket)
{
	SOCKET s2 = ((SOCKET*)client_socket)[0];
	char buf[100];
	char buf1[100];
	while (recv(s2, buf, sizeof(buf), 0))
	{
		int k, j = 0;
		k = strlen(buf) - 1;
		if (k % 4 == 0)
		{
			for (int i = k / 2; i < k; i++)
			{
				buf1[i] = buf[j];
				j++;
			}
			for (int i = 0; i < k / 2; i++)
			{
				buf1[i] = buf[j];
				j++;
			}
			buf1[k] = '\0';
			strcpy(buf, buf1);
		}
		cout << buf << endl;
		send(s2, buf, 100, 0);
	}
	closesocket(s2);
	return 0;
}
int numc1 = 0;
void print()
{
	if (numc1) printf("%d client connected\n", numc1);
	else printf("No clients connected\n");
}

int _tmain(int argc, _TCHAR* argv[])
{
	WORD wVersionRequested;
	WSADATA wsaData;
	int err;
	wVersionRequested = MAKEWORD(2, 2);
	err = WSAStartup(wVersionRequested, &wsaData);
	if (err != 0)
		return 0;
	SOCKET s = socket(AF_INET, SOCK_STREAM, 0);
	sockaddr_in local_addr;
	local_addr.sin_family = AF_INET;
	local_addr.sin_port = htons(1280);
	local_addr.sin_addr.s_addr = 0;
	bind(s, (sockaddr*)&local_addr, sizeof(local_addr));
	int c = listen(s, 5);
	cout << "Server receive ready" << endl;
	cout << endl;
	SOCKET client_socket;
	sockaddr_in client_addr;
	int client_addr_size = sizeof(client_addr);
	while ((client_socket = accept(s, (sockaddr*)&client_addr, &client_addr_size)))
	{
		numc1++;
		print();
		DWORD thID;
		CreateThread(NULL, NULL, ThreadFunc, &client_socket, NULL, &thID);
	}
	return 0;
}
