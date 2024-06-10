#define _CRT_SECURE_NO_WARNINGS
#include<Windows.h>		//<file> - ���������� ����� ������ file � ��������� ��������� Visual Studio
#include<CommCtrl.h>
#include<cstdio>
#include"resource.h"	//"file" - ���������� ����� ������ file ������� � �������� � ��������, � ����� � ��������� ��������� Visual Studio
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProc, 0);
	return 0;
}
//BOOL CheckMask(DWORD mask)
//{
//	//DWORD pattern = 1 << 32;
//	for (int i = 0; i < 32; i++)
//	{
//
//	}
//	return TRUE;
//}
//INT CountOnes(DWORD mask)
//{
//	DWORD zero_bits = 0;
//	DWORD power;
//	for (int i = 1; i; i <<= 1,zero_bits++)
//	{
//		if (mask & i)
//		{
//			power = i;
//			break;
//		}
//	}
//	return power;
//}
//��������� ���� - ��� ����� ������� �������, ������� ���������� ��� ������� ����.

//CHAR* ParseAddress(CHAR sz_address[],CHAR sz_description, DWORD dw_address)
//{
//
//}
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	//��� ����������� ��������� - ��� �������� �������� ������ 4 �����.
	//HWND - Handler to Window (���������� ����) - ��� �����, ������� �������������� ����.
	//����� ��������� � ���� ����� ��������� ������ ����� ��� ����������.
	//uMsg  (Message) - ���������, ������� ������������ ����.
	//wParam, lParam - ��������� ���������. ��� ��� ������� �� LOWORD � HIWORD.
	//LOWORD - ��� ������� �����.
	//HIWORD - ������� �����.
	//WORD (�����) - ��� ��� �����.
	int a = 2;
	{
		int a = 2;
	}
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		HWND hUpDown = GetDlgItem(hwnd, IDC_SPIN_PREFIX);
		//������� GetDlgItem() �������� HWND �������� ���������� �� ��� ID
		SendMessage(hUpDown, UDM_SETRANGE32, 0, 32);

		HWND hIPaddress = GetDlgItem(hwnd, IDC_IPADDRESS);
		SetFocus(hIPaddress);
	}
	break;
	case WM_COMMAND:
		//WM_ - Window Message
		switch (LOWORD(wParam))
		{
		case IDC_IPADDRESS:
		{
			CONST INT SIZE = 256;
			CHAR sz_info[SIZE]{};
			HWND hIPaddress = GetDlgItem(hwnd, IDC_IPADDRESS);
			HWND hIMask = GetDlgItem(hwnd, IDC_IPMASK);
			HWND hStaticInfo = GetDlgItem(hwnd, IDC_STATIC_INFO);
			HWND hEditPrefix = GetDlgItem(hwnd, IDC_EDIT_PREFIX);
			//EN_ - Edit notification (�����������)
			if (HIWORD(wParam) == EN_CHANGE)
			{
				//	//BYTE = 8 bit;		CHAR
				//	//WORD = 2 Bytes (16 bit);	SHORT
				//	//DWORD (Double Word - ������� ������) = 4 Bytes (32 bit)	INT
				//	//QWORD (Quad Word - ������������ �����) = 8 Bytes (64 bit)	LONG LONG
				//	//TBYTE (Ten Bytes - ������ ����) = 80 bit;
				//	//DQWORD (Double Quad Word - ������� ������������ �����) = 128 bit;
				DWORD dw_address;
				SendMessage(hIPaddress, IPM_GETADDRESS, 0, (LPARAM)&dw_address);
				INT first = FIRST_IPADDRESS(dw_address);
				INT second = SECOND_IPADDRESS(dw_address);
				INT third = THIRD_IPADDRESS(dw_address);
				INT fourth = FOURTH_IPADDRESS(dw_address);
				sprintf_s(sz_info, SIZE, "Info:\nFirst: %i, Second: %i, Third: %i, Forth: %i", first, second, third, fourth);
				SendMessage(hStaticInfo, WM_SETTEXT, 0, (LPARAM)sz_info);
				//////////////////////////////////////////////////////////////////////////////////

				if (first < 128)SendMessage(hEditPrefix, WM_SETTEXT, 0, (LPARAM)"8");
				else if (first < 192)SendMessage(hEditPrefix, WM_SETTEXT, 0, (LPARAM)"16");
				else if (first < 224)SendMessage(hEditPrefix, WM_SETTEXT, 0, (LPARAM)"24");
			}
		}
		break;
		case IDC_IPMASK:
		{
		//	if (HIWORD(wParam) == EN_CHANGE)
		//	{
		//		HWND hImask = GetDlgItem(hwnd, IDC_IPMASK);
		//		HWND hEditPrefix = GetDlgItem(hwnd, IDC_EDIT_PREFIX);
		//		DWORD dw_mask = 0;
		//		SendMessage(hImask, IPM_GETADDRESS, 0, (LPARAM)&dw_mask); // ����� ���������� (LPARAM)
		//		INT prefix = CountOnes(dw_mask);
		//		CHAR sz_prefix[3] = {};//sz string zero(������ ��������������� ����)
		//		sprintf(sz_prefix, "%i", prefix);
		//		SendMessage(hEditPrefix, WM_SETTEXT, 0, (LPARAM)sz_prefix);
		//	}
		}break;
		case IDC_EDIT_PREFIX:
		{
			HWND hIPAddress = GetDlgItem(hwnd, IDC_IPADDRESS);
			HWND hEditPrefix = GetDlgItem(hwnd, IDC_EDIT_PREFIX);
			HWND hIPmask = GetDlgItem(hwnd, IDC_IPMASK);
			HWND hStataticInfo = GetDlgItem(hwnd, IDC_STATIC_INFO);
			//DWORD dw_mask = UINT_MAX;
			DWORD dw_mask = ~0;
			if (HIWORD(wParam) == EN_CHANGE)
			{
				CONST INT SIZE_PREFIX = 8;
				CHAR sz_buffer[SIZE_PREFIX];
				SendMessage(hEditPrefix, WM_GETTEXT, SIZE_PREFIX, (LPARAM)sz_buffer);
				//MessageBox(hwnd, sz_buffer, "Prefix", MB_OK | MB_ICONINFORMATION);
				INT shift = atoi(sz_buffer);
				//dw_mask >>= (32 - shift);//������� atoi() ����������� ASCII-������ � �������� ���� 'int'
				//dw_mask <<= (32 - shift);
				//SendMessage(hIPmask, IPM_SETADDRESS, 0, dw_mask);
				SendMessage(hIPmask, IPM_SETADDRESS, 0, dw_mask /*>> (32 - shift)*/ <<= (32 - shift));

				////////////////////////////////
				
				CONST int SIZE = 256;
				CHAR sz_info[SIZE]{};
				CHAR sz_network_address[SIZE]{};
				CHAR sz_broadcast_address[SIZE]{};
				CHAR sz_number_of_hosts[SIZE]{};
				DWORD dw_address = 0;
				SendMessage(hIPAddress, IPM_GETADDRESS, 0, (LPARAM)&dw_address);
				DWORD dw_network_address = dw_address & dw_mask;
				sprintf
				(
					sz_network_address,
					"����� ����:\t%i.%i.%i.%i",
					FIRST_IPADDRESS(dw_network_address),
					SECOND_IPADDRESS(dw_network_address),
					THIRD_IPADDRESS(dw_network_address),
					FOURTH_IPADDRESS(dw_network_address)
				);
				DWORD dw_broadcast_address = ~dw_mask | dw_network_address;
				sprintf(
					sz_broadcast_address,
					"����������������� �����:\t%i.%i.%i.%i",
					FIRST_IPADDRESS(dw_broadcast_address),
					SECOND_IPADDRESS(dw_broadcast_address),
					THIRD_IPADDRESS(dw_broadcast_address),
					FOURTH_IPADDRESS(dw_broadcast_address)
				);
				DWORD dw_number_of_hosts = dw_broadcast_address - dw_network_address-1;
				sprintf(sz_number_of_hosts, "���������� �����:\t\t%u", dw_number_of_hosts);
				sprintf(
					sz_info,
					"Info:\n%s\n%s\n%s",
					sz_network_address,
					sz_broadcast_address,
					sz_number_of_hosts
				);
				SendMessage(hStataticInfo, WM_SETTEXT, 0, (LPARAM)sz_info);
			}
		}
		break;
		case IDOK: MessageBox(hwnd, "���� ������ ������ OK", "Info", MB_OK | MB_ICONINFORMATION); break;
			//	MB_OK | MB_ICONINFORMATION - MB_OK or MB_ICONINFORMATION
			// || - ���������� 'OR'
			// |  - ���������  'OR'
		case IDCANCEL: EndDialog(hwnd, 0); break;
		}
		break;
	case WM_NOTIFY:
	{
		HWND hImask = GetDlgItem(hwnd, IDC_IPMASK);
		HWND hEditPrefix = GetDlgItem(hwnd, IDC_EDIT_PREFIX);
		switch (wParam)
		{
			case IDC_IPMASK:
			{
				DWORD dw_mask = 0;
				SendMessage(hImask, IPM_GETADDRESS, 0, (LPARAM)&dw_mask); // ����� ���������� (LPARAM)
				int i = 32;
				for (; dw_mask & 1 ^ 1; i--)dw_mask >>= 1;// >>= 1 ����� ������ �� 1 ��� 
				CHAR sz_prefix[5]{};
				sprintf(sz_prefix, "%i", i);
				SendMessage(hEditPrefix, WM_SETTEXT, 0, (LPARAM)sz_prefix);
			}break;
		}break;
	}break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
	}
	return FALSE;
}
/*
NOT(��������)(~)- ������� �������� ������� ������� �������� ������ � ���� ���������(��������: ����� 5=0000 0101 �����  ~5=1111 1010)
�������� ������������ ��� ������ ������������� ����� � �������� ������� ���������. 
��� ���� ����� ����� ������������� ����� � �������� �� - ��� ����� ����� ���������������� �������� ����� � ��������� � ���� 1
OR(��������� ��������)(|) ��� ���������� ����� ����� 1, ���� ����� ��� ������ � ����� �������� ����� 1(��������: 7= 0000 0111 � 5= 0000 0101 �� ������� 0000 0111 = 7)
AND(��������� ���������)(&)���� ��������������� ��� ������ ������ ��������� ����� 0 �� � �� ����� 0(��������: 7= 0000 0111 � 5= 0000 0101 �� ������� 0000 0101 = 5)
XOR(^) ����� ������������ ��� ���������, ���� ���������� XOR � ���������� �������� ��������� ����� 0, ���� �� XOR-��� 2 ������ �������� ��������� ����� �������� �� 0
(��������: 7= 0000 0111 � 5= 0000 0101 �� ������� 0000 0010 = 2)
�������� AND ��������� ��������� ����� �� �������� ���� ��������� ��������� ����� �� 1 ����� 1 ����� �� ���, ���� ���� 0 �� ����� 0
*/