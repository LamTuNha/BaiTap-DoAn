#include <bits/stdc++.h>
using namespace std;

//=========================================================================================================================================
class Date{
	private:
		int ngay, thang, nam;		
	public:
		void InDate();
		void OutDate();	
};
	
//-----------------------------------------------------------------------------------------------------------------------------------------
void Date::InDate(){
	cout<<"\tNhap ngay bay (dd mm yyyy): ";
	cin>>ngay>>thang>>nam;
}
	
//-----------------------------------------------------------------------------------------------------------------------------------------	 
void Date::OutDate(){
	cout<<ngay<<"/"<<thang<<"/"<<nam;
}

//=========================================================================================================================================
class ChuyenBay{
	public:
	    string tenchuyen;
	    Date date;
	    int giave, id;	 
	public:
	    void InCB();
		void OutCB(); 		 
};

//-----------------------------------------------------------------------------------------------------------------------------------------	 -----------------------------------------------------------------------------------------------------------------------------------------	 
void ChuyenBay::InCB(){
	cout << "\tNhap ID: "; cin >> id;
	cout << "\tNhap Ten Chuyen: "; fflush(stdin); getline(cin,tenchuyen);
	date.InDate();
	cout << "\tNhap Gia Ve: "; cin >> giave;
	cout<<endl;
}
//-----------------------------------------------------------------------------------------------------------------------------------------	 
void ChuyenBay::OutCB(){
    cout <<id<<"\t"<<tenchuyen<<"\t\t\t";
	date.OutDate();
    cout << "\t\t" <<giave<< endl;
}

//=========================================================================================================================================
class HanhKhach{
	public:
    	string hoten, gioitinh, sdt, scm;
    	int tuoi; 
	public:
	    void InHK();
	    void OutHK();	    
};
  
//-----------------------------------------------------------------------------------------------------------------------------------------	 
void HanhKhach::InHK(){
    cout << "\tNhap CMT/CCCD: "; fflush(stdin); getline(cin,scm);
	cout << "\tNhap Ho Ten: "; fflush(stdin); getline(cin,hoten);
	cout << "\tNhap Gioi Tinh: "; fflush(stdin); getline(cin,gioitinh);
	cout << "\tNhap Tuoi: "; cin >>tuoi;
    cout << "\tNhap SDT: "; fflush(stdin); getline(cin,sdt);
	}
	
//-----------------------------------------------------------------------------------------------------------------------------------------	 
void HanhKhach::OutHK(){
	cout << "\tCMT/CCCD: " << scm << endl;
    cout << "\tHo ten: " << hoten << endl;
    cout << "\tGioi tinh: " << gioitinh <<".";
    cout << "\t\tTuoi: " << tuoi << endl;
    cout << "\tSDT: " << sdt << endl;
}

//=========================================================================================================================================
class Ve: public ChuyenBay, public HanhKhach{
	public:
	    ChuyenBay cb;
	    HanhKhach hk;	 
	public:
	    void InVe();
	    void OutVe();
};

//-----------------------------------------------------------------------------------------------------------------------------------------	
void Ve::InVe(){
	cout<<"Thong tin hanh khach:"<<endl;
	hk.InHK();
	cout<<"Thong tin chuyen bay:"<<endl;
	cb.InCB();
	cout<<endl;	
}
//-----------------------------------------------------------------------------------------------------------------------------------------	
void Ve::OutVe(){
	cout<<"Thong tin hanh khach:"<<endl;
	hk.OutHK();
	cout<<"Thong tin chuyen bay:"<<endl;
	cout<<"\tID\tTen chuyen bay\t\t\t\tNgay bay\t\tGia ve"<<endl;
	cout<<"\t";
	cb.OutCB();	
	cout<<endl;
}

//=========================================================================================================================================
class QuanLy: public Ve, public ChuyenBay{
	private:
	    Ve ve[100];
	    ChuyenBay cb[100];
	    HanhKhach hk;
		int n, m, ma;	
		string index; 
		string fileName[];
	public:
	    void NhapCB();
	    void XuatCB();
	    void SXCB();
	    void TKCB();
	    int XoaCB();
	    void SuaCB();
		void NhapVe();
	    void XuatVe();
	    void SXVe();
	    void TKVe();
	    int XoaVe();
	    void SuaVe();
	    void GhiFile();
		int DocFile();
};

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::NhapCB(){
	cout<<"------------------------------------------------------------------------------------------------" <<endl;
	cout<<"Nhap so luong chuyen bay: "; cin>>n;
	cout<<endl;
	for(int i=1;i<=n;i++){
		cout<<"Nhap thong tin chuyen bay thu " <<i<<":"<<endl;
		cb[i].InCB();
		cout<<"------------------------------------------------------------------------------------------------" <<endl;
	}
	cout<<endl;
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::XuatCB(){
	cout<<"\nDanh sach thong tin chuyen bay:"<<endl;
	cout<<"------------------------------------------------------------------------------------------------" <<endl;
	cout<<"STT\tID\tTen chuyen bay\t\t\t\tNgay bay\t\tGia ve"<<endl;
	cout<<"------------------------------------------------------------------------------------------------" <<endl;	
	for(int i=1;i<=n;i++){
		cout<<i<<"\t";
		cb[i].OutCB();
	}
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::SXCB(){
	ChuyenBay gan;
	int lc;
	cout << "\t  1.  Sap xep theo ten chuyen bay.\n";
	cout << "\t  2.  Sap xep theo gia ve.\n";
	cout << "\t  3.  Sap xep theo id.\n";
	cout << "\tNhap tuy chon: ";cin >> lc;
	cout<<"------------------------------------------------------------------------------------------------" <<endl;
	cout<<"STT\tID\tTen chuyen bay\t\t\tNgay bay\t\tGia ve"<<endl;
	cout<<"------------------------------------------------------------------------------------------------" <<endl;
	switch(lc) {
      	case 1:
      		for(int i = 1;i <= n;i++){
				for(int j = i+1; j <= n;j++){
					if(cb[i].tenchuyen > cb[j].tenchuyen){
				    gan = cb[i];
				    cb[i] = cb[j];
				    cb[j] = gan;				
					}		
				}	
				cout<<i<<"\t";
				cb[i].OutCB();
			}				
         	break;
      	case 2:
      		for(int i = 1;i <= n;i++){
				for(int j = i+1; j <= n;j++){
					if(cb[i].giave > cb[j].giave){
				    gan = cb[i];
				    cb[i] = cb[j];
				    cb[j] = gan;				
					}		
				}	
				cout<<i<<"\t";
				cb[i].OutCB();
			}		
      		break;	
      	case 3:
      		for(int i = 1;i <= n;i++){
				for(int j = i+1; j <= n;j++){
					if(cb[i].id > cb[j].id){
				    gan = cb[i];
				    cb[i] = cb[j];
				    cb[j] = gan;				
					}		
				}	
				cout<<i<<"\t";
				cb[i].OutCB();
			}				
         	break;
      	default:
        	 cout << "Khong co lua chon nay" << endl;
	}
	
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::TKCB(){
	int lc, gia;
	int found=0;
	cout << "\t  1.  Tim kiem theo ten chuyen bay.\n";
	cout << "\t  2.  Tim kiem theo gia ve.\n";
	cout << "\t  3.  Tim kiem theo ID.\n";
	cout << "\tNhap tuy chon: ";cin >> lc;
	switch(lc) {
      	case 1:      		
		    cout << "\nNhap ten chuyen bay: "; fflush(stdin); getline(cin,index);
		    cout<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
			cout<<"STT\tID\tTen chuyen bay\t\t\tNgay bay\t\tGia ve"<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
		    for(int i = 1; i <= n; i++) {
		        if (cb[i].tenchuyen == index) {
		            found = 1;
					cout<<i<<"\t";
					cb[i].OutCB();
		        }
		    }
		    if (found == 0) {
		        cout<<"\nChuyen bay khong ton tai."<<endl;
		    }	
    		break;
      	case 2:
      		cout << "\nNhap gia ve: "; cin>> gia;
		    cout<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
			cout<<"STT\tID\tTen chuyen bay\t\t\tNgay bay\t\tGia ve"<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
		    for(int i = 1; i <= n; i++) {
		        if (cb[i].giave == gia) {
		            found = 1;
		            cout<<i<<"\t";
					cb[i].OutCB();
		        }
		    }
		    if (found == 0) {
		        cout<<"\nChuyen bay khong ton tai."<<endl;
		    }	
    		break;

      	case 3:
      		cout << "\nNhap ID: "; cin>> ma;
		    cout<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
			cout<<"STT\tID\tTen chuyen bay\t\t\tNgay bay\t\tGia ve"<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
		    for(int i = 1; i <= n; i++) {
		        if (cb[i].id == ma) {
		            found = 1;
		            cout<<i<<"\t";
					cb[i].OutCB();
		        }
		    }
		    if (found == 0) {
		        cout<<"\nChuyen bay khong ton tai."<<endl;
		    }	
         	break;
      	default:
        	 cout << "Khong co lua chon nay" << endl;
	}
	
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
int QuanLy::XoaCB(){
	int found=0;
    	cout << "\nNhap ID chuyen bay: "; cin >> ma;
    for(int i = 1; i <= n; i++) {
        if (cb[i].id == ma) {
            found = 1;
            for (int j = i; j < n; j++) {
            	cb[j] = cb[j+1];
        	}
            cout << "\nDa xoa chuyen bay co id: " << ma<<endl;
            n--;
            break;
        }
    }
    if (found == 0) {
        cout<<"\nChuyen bay - id: "<<ma<<" khong ton tai."<<endl;
        return 0;
    }else {
        return 1;
    }
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::SuaCB(){
	int found = 0;
	cout << "\nNhap ID: "; cin >> ma;
    for(int i = 1; i <= n; i++) {
        if (cb[i].id == ma) {
            found = 1;
			cb[i].InCB();
            break;
        }
    }
    if (found == 0) {
        cout<<"\nChuyen bay - id: "<<ma<<" khong ton tai."<<endl;
    }
	
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::NhapVe(){
	cout<<"------------------------------------------------------------------------------------------------" <<endl;
	cout<<"Nhap so luong ve may bay: "; cin>>m;
	cout<<endl;
	for(int i=1;i<=m;i++){
		cout<<"Nhap thong tin ve thu " <<i<<":"<<endl;
		ve[i].InVe();
		cout<<"------------------------------------------------------------------------------------------------" <<endl;
	}
	cout<<endl;
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::XuatVe(){
	cout<<"\nDanh sach thong tin ve:"<<endl;
	cout<<"------------------------------------------------------------------------------------------------" <<endl;
	for(int i=1;i<=m;i++){
		cout<<"Ve thu: "<<i<<"."<<endl;
		ve[i].OutVe();
		cout<<"------------------------------------------------------------------------------------------------" <<endl;
	}
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::SXVe(){
	Ve gan;
	int lc;
	cout << "\t  1.  Sap xep theo ten chuyen bay.\n";
	cout << "\t  2.  Sap xep theo ID.\n";
	cout << "\t  3.  Sap xep theo ten khach hang.\n";
	cout << "\tNhap tuy chon: ";cin >> lc;
	cout<<"------------------------------------------------------------------------------------------------" <<endl;
	switch(lc) {
      	case 1:
      		for(int i = 1;i <= m;i++){
				for(int j = i+1; j <= m;j++){
					if(ve[i].cb.tenchuyen > ve[j].cb.tenchuyen){
				    gan = ve[i];
				    ve[i] = ve[j];
				    ve[j] = gan;				
					}		
				}	
				cout<<"Ve thu: "<<i<<"."<<endl;
				ve[i].OutVe();
				cout<<"------------------------------------------------------------------------------------------------" <<endl;
			}				
         	break;
      	case 2:
      		for(int i = 1;i <= m;i++){
				for(int j = i+1; j <= m;j++){
					if(ve[i].cb.id > ve[j].cb.id){
				    gan = ve[i];
				    ve[i] = ve[j];
				    ve[j] = gan;				
					}		
				}	
				cout<<"Ve thu: "<<i<<"."<<endl;
				ve[i].OutVe();
				cout<<"------------------------------------------------------------------------------------------------" <<endl;
			}		
      		break;	
      	case 3:
      		for(int i = 1;i <= m;i++){
				for(int j = i+1; j <= m;j++){
					if(ve[i].hk.hoten > ve[j].hk.hoten){
				    gan = ve[i];
				    ve[i] = ve[j];
				    ve[j] = gan;				
					}		
				}	
				cout<<"Ve thu: "<<i<<"."<<endl;
				ve[i].OutVe();
				cout<<"------------------------------------------------------------------------------------------------" <<endl;
			}				
         	break;
      	default:
        	 cout << "Khong co lua chon nay" << endl;
	}
	
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::TKVe(){
	int lc;
	int found=0;
	cout << "\t  1.  Tim kiem theo ten chuyen bay.\n";
	cout << "\t  2.  Tim kiem theo CMT/CCCD.\n";
	cout << "\t  3.  Tim kiem theo ID.\n";
	cout << "\t  3.  Tim kiem theo SDT.\n";
	cout << "\tNhap tuy chon: ";cin >> lc;
	switch(lc) {
      	case 1:      		
		    cout << "\nNhap ten chuyen bay: "; fflush(stdin); getline(cin,index);
		    cout<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
		    for(int i = 1; i <= m; i++) {
		        if (ve[i].cb.tenchuyen == index) {
		            found = 1;
					cout<<"Ve thu: "<<i<<"."<<endl;
					ve[i].OutVe();
					cout<<"------------------------------------------------------------------------------------------------" <<endl;
		        }
		    }
		    if (found == 0) {
		        cout<<"\nVe khong ton tai."<<endl;
		    }	
    		break;
      	case 2:
      		cout << "\nNhap so CMT/CCCD: "; fflush(stdin); getline(cin,index);
		    cout<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
		    for(int i = 1; i <= m; i++) {
		        if (ve[i].hk.scm == index) {
		            found = 1;
					cout<<"Ve thu: "<<i<<"."<<endl;
					ve[i].OutVe();
					cout<<"------------------------------------------------------------------------------------------------" <<endl;
		        }
		    }
		    if (found == 0) {
		        cout<<"\nVe khong ton tai."<<endl;
		    }	
    		break;
      	case 3:
      		cout << "\nNhap ID: "; cin>> ma;
		    cout<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
			cout<<"STT\tID\tTen chuyen bay\t\t\tNgay bay\t\tGia ve"<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
		    for(int i = 1; i <= m; i++) {
		        if (ve[i].cb.id == ma) {
		            found = 1;
					cout<<"Ve thu: "<<i<<"."<<endl;
					ve[i].OutVe();
					cout<<"------------------------------------------------------------------------------------------------" <<endl;
		        }
		    }
		    if (found == 0) {
		        cout<<"\nChuyen bay khong ton tai."<<endl;
		    }	
         	break;
        case 4:
      		cout << "\nNhap SDT: "; fflush(stdin); getline(cin,index);
		    cout<<endl;
			cout<<"------------------------------------------------------------------------------------------------" <<endl;
		    for(int i = 1; i <= m; i++) {
		        if (ve[i].hk.sdt == index) {
		            found = 1;
					cout<<"Ve thu: "<<i<<"."<<endl;
					ve[i].OutVe();
					cout<<"------------------------------------------------------------------------------------------------" <<endl;
		        }
		    }
		    if (found == 0) {
		        cout<<"\nChuyen bay khong ton tai."<<endl;
		    }	
    		break;
      	default:
        	 cout << "Khong co lua chon nay" << endl;
	}
	
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
void QuanLy::SuaVe(){
	int found = 0;
	cout << "\nNhap CMT/CCCD: "; fflush(stdin); getline(cin,index);
    for(int i = 1; i <= m; i++) {
        if (ve[i].hk.scm == index) {
            found = 1;
			ve[i].InVe();
            break;
        }
    }
    if (found == 0) {
        cout<<"\nVe khong ton tai."<<endl;
    }
	
}

//-----------------------------------------------------------------------------------------------------------------------------------------	
int QuanLy::XoaVe(){
	int found=0;
    	cout << "\nNhap CMT/CCCD: "; fflush(stdin); getline(cin,index);
    for(int i = 1; i <= m; i++) {
        if (ve[i].hk.scm== index) {
            found = 1;
            for (int j = i; j < n; j++) {
            	ve[j] = ve[j+1];
        	}
            cout << "\nDa xoa ve cua hanh khach co CMT/CCCD: " << index<<endl;
            n--;
            break;
        }
    }
    if (found == 0) {
        cout<<"\nVe khong ton tai."<<endl;
        return 0;
    }else {
        return 1;
    }
}
/*int QuanLy::DocFile() {
    FILE * fp;
    int i = 0;
    fp = fopen ("QL.txt", "r");
    cout << "Chuan bi doc file: "; puts("QL.txt");	
    while (fscanf(fp, "%10s%30s%5s%5d%10s%10d%30s%10d\n", &ve[i].hk.scm, &ve[i].hk.hoten, &ve[i].hk.gioitinh, &ve[i].hk.tuoi, &ve[i].hk.sdt,
				&ve[i].cb.id, &ve[i].cb.tenchuyen, &ve[i].cb.giave) != EOF) {
       i++;
       cout << " Doc ban ghi thu: " << i << endl;
    }
    cout << " So luong sinh vien co san trong file la: " << i << endl;
    cout << endl;
    fclose (fp);
    return i;
}
 
void QuanLy::GhiFile() {
    FILE * fp;
    fp = fopen ("QL.txt","w");
    for(int i = 0;i < n;i++){
        fprintf(fp, "%10s%30s%5s%5d%10s%10d%30s%10d\n", ve[i].hk.scm, ve[i].hk.hoten, ve[i].hk.gioitinh, ve[i].hk.tuoi, ve[i].hk.sdt,
				ve[i].cb.id, ve[i].cb.tenchuyen, ve[i].cb.giave);
    }
    fclose (fp);
}
*/

//=========================================================================================================================================
int main(){
	QuanLy ql;
	int key, soCB = 0, soVe = 0;
    while(true) {
        cout << "\tCHUONG TRINH QUAN LY VE MAY BAY C++\n";
        cout << "\t**************************MENU***************************\n";
        cout << "\t**  1.  Them Chuyen Bay.                               **\n";
        cout << "\t**  2.  Danh Sach Chuyen Bay.                          **\n";
        cout << "\t**  3.  Sap xep danh sach chuyen bay.                  **\n";
        cout << "\t**  4.  Tim kiem chuyen bay.                           **\n";
        cout << "\t**  5.  Xoa chuyen bay theo id.                        **\n";
    	cout << "\t**  6.  Sua thong tin chuyen bay theo id.              **\n";
    	cout << "\t**                                                     **\n";
        cout << "\t**  7.  Them thong tin ve.                             **\n";
        cout << "\t**  8.  Danh sach ve.                                  **\n";
        cout << "\t**  9.  Sap xep danh sach ve.                          **\n";
        cout << "\t**  10. Tim kiem thong tin ve.                         **\n";
        cout << "\t**  11. Xoa ve theo CMT/CCCD.                          **\n";
        cout << "\t**  12. Sua ve theo CMT/CCCD.                          **\n";
        cout << "\t**                                                     **\n";
        cout << "\t**  0. Thoat                                           **\n";
        cout << "\t*********************************************************\n";
        cout << "\tNhap tuy chon: ";cin >> key;
        switch(key){
            case 1:
                cout << "\nThem Chuyen Bay.\n"<<endl;
                ql.NhapCB();
                cout<<"\nThem Chuyen Bay Thanh Cong!"<<endl;
                soCB++;
                system("pause");
                system("cls");
                break;
            case 2:
                if(soCB > 0){
                	cout<<"\nDanh sach thong tin chuyen bay:"<<endl;
                    ql.XuatCB();
                    
                }else{
					cout << "\nDanh sach chuyen bay trong!"<<endl;
                    
                }
				cout<<"\n------------------------------------------------------------------------------------------------" <<endl;               
                system("pause");
				system("cls");
                break;
            case 3:
                if(soCB > 0) {
                    cout << "\nSap xep danh sach chuyen bay."<<endl;
                    ql.SXCB();
                }else{                    
				   cout << "\nDanh sach chuyen bay trong!"<<endl;
                    
                }
                cout<<"\n------------------------------------------------------------------------------------------------" <<endl;
                system("pause");
				system("cls");
                break;
            case 4:
                if(soCB > 0) {
                    cout << "\nTim kiem thong tin chuyen bay. "<<endl;
                    ql.TKCB();
                }else{
                    cout << "\nDanh sach chuyen bay trong!"<<endl;
                }
                cout<<"\n------------------------------------------------------------------------------------------------" <<endl;
                system("pause");
				system("cls");
                break;
            case 5:
                if(soCB > 0) {
                    cout << "\nXoa chuyen bay theo id."<<endl;
                    ql.XoaCB();
                }else{
                    cout << "\nDanh sach chuyen bay trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 6:
                if(soCB > 0) {
                    cout << "\nSua thong tin chuyen bay theo id. "<<endl;
                    ql.SuaCB();
                }else{
                    cout << "\nDanh chuyen bay trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 7:
                cout << "\nThem thong tin ve.\n"<<endl;
                ql.NhapVe();
                cout<<"\nThem Chuyen Bay Thanh Cong!"<<endl;
                soVe++;
                system("pause");
                system("cls");
                break;
            case 8:
                if(soVe > 0){
                    ql.XuatVe();                    
                }else{
					cout << "\nDanh sach ve trong!"<<endl;
                    
                }
                system("pause");
				system("cls");
                break;
            case 9:
                if(soVe > 0) {
                    cout << "\nSap xep danh sach ve."<<endl;
                    ql.SXVe();
                }else{                    
				   cout << "\nDanh sach ve trong!"<<endl;
                    
                }
                cout<<"\n------------------------------------------------------------------------------------------------" <<endl;
                system("pause");
				system("cls");
                break;
            case 10:
                if(soVe > 0) {
                    cout << "\nTim kiem thong tin ve. "<<endl;
                    ql.TKVe();
                }else{
                    cout << "\nDanh sach ve trong!"<<endl;
                }
                cout<<"\n------------------------------------------------------------------------------------------------" <<endl;
                system("pause");
				system("cls");
                break;
            case 11:
                if(soVe > 0) {
                    cout << "\nXoa ve theo CMT/CCCD."<<endl;
                    ql.XoaVe();
                }else{
                    cout << "\nDanh sach ve trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            case 12:
                if(soVe > 0) {
                    cout << "\nSua thong tin ve theo CMT/CCCD. "<<endl;
                    ql.SuaVe();
                }else{
                    cout << "\nDanh chuyen bay trong!"<<endl;
                }
                system("pause");
				system("cls");
                break;
            /*case 13:
                if(soVe > 0){
                    cout << "\nGhi danh sach sinh vien vao file.";
                    ql.GhiFile();
                }else{
                    cout << "\nSanh sach sinh vien trong!";
                }
                cout<<"\nGhi danh sach sinh vien vao file 'QL.txt' thanh cong\n\n!";
                
                system("pause");
				system("cls");
                break;*/
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






