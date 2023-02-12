#include<conio.h>
#include<stdio.h>
#include <iostream>
#include <string.h>
#define MAX 100
#include <iomanip>
#include <fstream>
using namespace std;

// ----- Class Ngay, Thang, Nam Sinh. -----
class Date{
	private :
		int ngay, thang, nam;
	public:
		void NhapDate();
		void XuatDate();
	
};
void Date::NhapDate(){
    cout<<"Nhap ngay, thang, nam sinh(dd/mm/yyyy)  ";
    cin>>ngay>>thang>>nam;
}
 
void Date::XuatDate(){
    cout<<ngay<<"/"<<thang<<"/"<<nam;
}

// ----- Class Sinh Vien. -----
class SinhVien: public Date{
	public :
		int masv;
		string lop, hoten, gioitinh, quequan;
		Date date;
	public:
		void NhapSV();
		void XuatSV();
};
void SinhVien::NhapSV(){
	cout<<"Nhap ten lop: ";fflush(stdin); getline(cin,lop);
	cout<<"Nhap ma sv: "; cin>>masv;
	cout<<"Nhap ho ten: "; fflush(stdin); getline(cin,hoten);
	cout<<"Nhap gioi tinh: "; fflush(stdin); getline(cin,gioitinh);
	date.NhapDate();
	cout<<"Nhap que quan: "; fflush(stdin); getline(cin,quequan);
}
void SinhVien::XuatSV(){
	cout<<lop<<"	"<<masv<<"	"<<hoten<<"	"<<gioitinh<<"	";
	date.XuatDate();cout<<"	"<<quequan;
}

//----- Class Quan Ly Sinh Vien. -----
class QLSV: public SinhVien{
	private:
		int n, ma;
		float dtb, toan, van, anh;
		string hocluc, index;
		SinhVien sv;
	public:
		void Nhap();
		void Xuat();
		void HocLuc();
		void DTB();
		void HienThi();
		void TK_MaSV();
		void TK_Lop();
		void TK_HocLuc();
		void SX_DTB();
		void SX_Lop();
		void SX_Ten();
		int Xoa();
		void Sua();
		
};
QLSV ql[100];

void QLSV::DTB(){
	for(int i=1;i<=n;i++)
	{
	ql[i].dtb=((ql[i].toan+ql[i].van+ql[i].anh)/3);
	}
}

void QLSV::HocLuc(){
	for(int i=1;i<=n;i++)
	{
		if (ql[i].dtb >= 8 && ql[i].dtb <= 10){
			ql[i].hocluc="Gioi";
		}
		else if(ql[i].dtb >= 6.5 && ql[i].dtb < 8){
			ql[i].hocluc="Kha";
		}
		else if (ql[i].dtb >= 5 && ql[i].dtb <6.5){
			ql[i].hocluc="Trung Binh";
		}
		else if (ql[i].dtb>=0 && ql[i].dtb <5) {
			ql[i].hocluc="Yeu";
		}
		else {
			ql[i].hocluc="Loi ";
		}
	}
}
void QLSV::Nhap(){
	cout<<"-----------------------------------------------" <<endl;	
	cout<<"Nhap so luong sinh vien: "; cin>>n;
	for(int i=1;i<=n;i++){
	cout<<"Nhap thong tin sv thu " <<i<<""<<endl;
	ql[i].NhapSV();
	cout<<"Nhap diem Toan: "; cin>>ql[i].toan;
	cout<<"Nhap diem Van: "; cin>>ql[i].van;
	cout<<"Nhap diem T.Anh: "; cin>>ql[i].anh;
	ql[i].dtb;
	cout<<"-----------------------------------------------" <<endl;	
	}
}
void QLSV::Xuat(){
	XuatSV();cout<<"	"<<toan<<"	"<<van<<"	"<<anh<<"	"<<dtb<<"	"<<hocluc;
	
}
void QLSV::HienThi(){
	cout<<"Hien thi thong tin sinh vien"<<endl;
	for(int i=1;i<=n;i++)
	{
	ql[i].Xuat();cout<<endl;
	}
}
void QLSV::SX_DTB(){
	QLSV gan;            
	for(int i = 1;i <= n;i++){
		for(int j = i+1; j <= n;j++){
			if(ql[i].dtb > ql[j].dtb){
			    gan = ql[i];
			    ql[i] = ql[j];
			    ql[j] = gan;				
			}		
		}	
		ql[i].Xuat();	
	}		
}
void QLSV::SX_Lop(){
	QLSV gan;            
	for(int i = 1;i <= n;i++){
		for(int j = i+1; j <= n;j++){
			if(ql[i].lop > ql[j].lop){
			    gan = ql[i];
			    ql[i] = ql[j];
			    ql[j] = gan;				
			}		
		}	
		ql[i].Xuat();	
	}		
}
void QLSV::SX_Ten(){
	QLSV gan;            
	for(int i = 1;i <= n;i++){
		for(int j = i+1; j <= n;j++){
			if(ql[i].hoten > ql[j].hoten){
			    gan = ql[i];
			    ql[i] = ql[j];
			    ql[j] = gan;				
			}		
		}	
		ql[i].Xuat();	
	}		
}
void QLSV::TK_MaSV(){
	int found=0;
    		cout << "\n Nhap Ma SV: "; cin >> ma;
    for(int i = 1; i <= n; i++) {
        if (ql[i].masv == ma) {
            found = 1;
            cout << "\n Thong tin sinh vien co ma sinh vien la: "<<ql[i].masv<<""<<endl;
            ql[i].Xuat();
            break;
        }
    }
    if (found == 0) {
        cout<<"\n Ma sinh vien khong ton tai."<<endl;
    }	
}
void QLSV::TK_Lop(){
	int found=0;
    	cout << "\n Nhap Ten Lop: "; fflush(stdin); getline(cin,index);
    for(int i = 1; i <= n; i++) {
        if (ql[i].lop == index) {
            found = 1;
            cout << "\n Thong tin sinh vien co lop la: "<<ql[i].lop<<""<<endl;
            ql[i].Xuat();
            break;
        }
    }
    if (found == 0) {
        cout<<"\n Lop khong ton tai."<<endl;
    }	
}
void QLSV::TK_HocLuc(){
	int found=0;
    	cout << "\n Nhap Hoc Luc(Gioi-Kha-Trung Binh-Yeu): "; fflush(stdin); getline(cin,index);
    for(int i = 1; i <= n; i++) {
        if (ql[i].hocluc == index) {
            found = 1;
            cout << "\n Thong tin sinh vien co hoc luc la: "<<ql[i].hocluc<<""<<endl;
            ql[i].Xuat();
            break;
        }
    }
    if (found == 0) {
        cout<<"\n Khong co sinh vien nao co hoc luc: "<<index<<endl;
    }	
}
int QLSV::Xoa(){
	int found=0;
    	cout << "\n Nhap Ma SV: "; cin >> ma;
    for(int i = 1; i <= n; i++) {
        if (ql[i].masv == ma) {
            found = 1;
            for (int j = i; j < n; j++) {
            	ql[j] = ql[j+1];
        	}
            cout << "\n Da xoa SV co Ma SV = " << ma<<endl;
            break;
        }
    }
    if (found == 0) {
        cout<<"\n Sinh vien co Ma SV: "<<ma<<" khong ton tai."<<endl;
        return 0;
    }else {
        return 1;
    }
}
void QLSV::Sua(){
	int found = 0;
	cout << "\n Nhap Ma SV: "; cin >> ma;
    for(int i = 1; i <= n; i++) {
        if (ql[i].masv == ma) {
            found = 1;
            cout << "\n Cap nhat thong tin sinh vien co masv = " << ma<<endl;
            cout<<"Nhap ten lop: ";fflush(stdin); getline(cin,lop);
			cout<<"Nhap ma sv: "; cin>>masv;
			cout<<"Nhap ho ten: "; fflush(stdin); getline(cin,hoten);
			cout<<"Nhap gioi tinh: "; fflush(stdin); getline(cin,gioitinh);
			date.NhapDate();
			cout<<"Nhap que quan: "; fflush(stdin); getline(cin,quequan);
			cout<<"Nhap diem Toan: "; cin>>ql[i].toan;
			cout<<"Nhap diem Van: "; cin>>ql[i].van;
			cout<<"Nhap diem T.Anh: "; cin>>ql[i].anh;
            break;
        }
    }
    if (found == 0) {
        cout<<"\n Sinh vien co masv: "<<ma<<" khong ton tai."<<endl;
    }
	
}

int main(){
	QLSV ql;
	int key, soSV=0;
    while(true) {
        cout << "\tCHUONG TRINH QUAN LY SINH VIEN C++\n";
        cout << "\t**************************MENU***************************\n";
        cout << "\t**  1.  Them sinh vien.                                **\n";
        cout << "\t**  2.  Hien thi danh sach sinh vien.                  **\n";
        cout << "\t**            ---- Sap Xep ----                        **\n";
        cout << "\t**  3.  Sap xeo theo DTB.                              **\n";
        cout << "\t**  4.  Sap xeo theo Lop.                              **\n";
        cout << "\t**  5.  Sap xeo theo Ho ten SV.                        **\n";
    	cout << "\t**            ---- Tim Kiem ----                       **\n";
        cout << "\t**  6.  Tim kiem TT SV theo Ma SV.                     **\n";
        cout << "\t**  7.  Tim kiem TT SV theo Lop.                       **\n";
        cout << "\t**  8.  Tim kiem TT SV theo Hoc luc.                   **\n";
        cout << "\t**            ---- Sua, Xoa ----                       **\n";
        cout << "\t**  9.  Xoa TT SV theo Ma SV.                          **\n";
        cout << "\t**  10. Sua TT SV theo Ma SV.                          **\n";
        cout << "\t**  0. Thoat                                           **\n";
        cout << "\t*********************************************************\n";
        cout << "\tNhap tuy chon: ";cin >> key;
        switch(key){
            case 1:
                cout << "\n1. Them sinh vien.\n"<<endl;
                ql.Nhap();
                ql.DTB();
                ql.HocLuc();
                cout<<"\nThem sinh vien thanh cong!"<<endl;
                soSV++;
                system("pause");
                system("cls");
                break;
            case 2:
                if(soSV > 0){
                    cout << "\n2. Hien thi danh sach sinh vien."<<endl;
                    ql.HienThi();
                }else{
					cout << "\nDanh sach sinh vien trong!"<<endl;
                    
                }                
                system("pause");
				system("cls");
                break;
            case 3:
                if(soSV > 0) {
                    cout << "\n3. Sap xep theo DTB."<<endl;
                    ql.SX_DTB();
                }else{                    
				   cout << "\nSanh sach sinh vien trong!"<<endl;
                    
                }
                system("pause");
				system("cls");
                break;
            case 4:
                if(soSV > 0) {
                    cout << "\n4. Sap xep theo Lop."<<endl;
                    ql.SX_Lop();
                }else{                    
				   cout << "\nSanh sach sinh vien trong!"<<endl;
                    
                }
                system("pause");
				system("cls");
                break;
            case 5:
                if(soSV > 0) {
                    cout << "\n5. Sap xep theo Ten SV."<<endl;
                    ql.SX_Ten();
                }else{                    
				   cout << "\nSanh sach sinh vien trong!"<<endl;
                    
                }
                system("pause");
				system("cls");
                break;
            case 6:
                if(soSV > 0) {

                    cout << "\n6. Tim kiem sinh vien theo ma sinh vien. "<<endl;
                    ql.TK_MaSV();
                }else{
                    cout << "\nDanh sach sinh vien trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 7:
                if(soSV > 0) {

                    cout << "\n7. Tim kiem sinh vien theo ma sinh vien. "<<endl;
                    ql.TK_Lop();
                }else{
                    cout << "\nDanh sach sinh vien trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 8:
                if(soSV > 0) {

                    cout << "\n8. Tim kiem sinh vien theo Hoc luc. "<<endl;
                    ql.TK_HocLuc();
                }else{
                    cout << "\nDanh sach sinh vien trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 9:
                if(soSV > 0) {

                    cout << "\n9. Xoa TT SV theo MaSV. "<<endl;
                    ql.Xoa();
                }else{
                    cout << "\nDanh sach sinh vien trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 10:
                if(soSV > 0) {

                    cout << "\n9. Sua TT SV theo MaSV. "<<endl;
                    ql.Sua();
                }else{
                    cout << "\nDanh sach sinh vien trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 0:
                cout << "\nBan da chon thoat chuong trinh!"<<endl;
                return 0;
            default:
                cout << "\nKhong co chuc nang nay!"<<endl;
                cout << "\nHay chon chuc nang trong hop menu."<<endl;
                system("pause");
				system("cls");
                break;
        }
    }
}

