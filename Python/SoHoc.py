class Sach:
    TS = 0
    TG = 0
    GB = 0
    def __init__(self, TenSach=0, TacGia=0, GiaBan=0):
        self.TS = TenSach
        self.TG = TacGia
        self.GB = GiaBan

    def NhapS(self,TS,TG,GB):
        self.TS = input("Nhap Ten Sach: ")
        self.TG = input("Nhap Ten Tac Gia: ")
        self.GB = float(input("Nhap Gia Ban: "))

    def _TS(self):
        return self.TS

    def _TG(self):
        return self.TG

    def _GB(self):
        return self.GB

    def XuatS(self):
        print("Ten Sach: ", self.TS)
        print("Tac Gia: ", self.TG)
        print("Gia: ", self.GB)

class Bia(Sach):
    MaHA = 0
    TV = 0
    def __init__(self, MaHA=0, TienVe=0):
        Sach.__init__(self)
        self.MaHA = MaHA
        self.TV = TienVe

    def NhapBia(self,MaHA,TV):
        self.MaHA = input("Nhap Ma Hinh Anh: ")
        self.TV = float(input("Nhap Tien Ve: "))

    def _MaHA(self):
        return self.MaHA

    def _TV(self):
        return self.TV

    def XuatBia(self):
        print("Ma Hinh Anh: ", self.MaHA)
        print("Tien Ve: ", self.TV)

class HoaSy:
    TenHS = 0
    DiaChi = 0
    def __init__(self, TenHS=0, DiaChi=0):
        self.TenHS = TenHS
        self.DiaChi = DiaChi

    def NhapHS(self,TenHS,DiaChi):
        self.TenHS = input("Nhap Ten Hoa Sy: ")
        self.DiaChi = input("Nhap Dia Chi: ")

    def _TenHS(self):
        return self.TenHS

    def _DiaChi(self):
        return self.DiaChi

    def XuatHS(self):
        print("Ten Hoa Sy: ", self.TenHS)
        print("Dia Chi Hoa Sy: ", self.DiaChi)

class SachVeBia(Bia,HoaSy):

    def __init__(self):
        Sach.__init__(self)
        Bia.__init__(self)
        HoaSy.__init__(self)

    def TT(self,GB,TV):
        tt = self.GB + self.TV
        return tt

    def NhapSach(self,TS,TG,GB,MaHA,TV,TenHS,DiaChi):
        print("Nhap Sach: ")
        print("Lua chon loai sach can nhap: ")
        print("1. Sach khong bia. ")
        print("2. Sach co bia. ")
        n = int(input("Nhap lua chon: "))
        if n==1:
            print("----- Sach Khong Bia -----")
            SachVeBia().NhapS(self.TS,self.TG,self.GB)
        elif n==2:
            print("----- Sach Ve Bia -----")
            SachVeBia().NhapS(self.TS,self.TG,self.GB)
            SachVeBia().NhapBia(self.MaHA, self.TV)
            SachVeBia().NhapHS(self.TenHS,self.DiaChi)
        else:
            print("Khong co lua chon nay! Hay nhap lai lua chon !")
            return SachVeBia().NhapSach()

    def XuatSach(self):
        print("----- Hien Thi Thong Tin Sach -----")
        SachVeBia().XuatS()
        SachVeBia().XuatBia()
        SachVeBia().XuatHS()
        print("Tong Tien: ",self.TT(self.GB,self.TV))


TenSach = 0
TacGia = 0
GiaBan = 0
MaHA = 0
TienVe = 0
TenHS = 0
DiaChi = 0
Main = SachVeBia()
Main.NhapSach(TenSach,TacGia,GiaBan,TenHS,DiaChi,MaHA,TienVe)
Main.XuatSach()

