class Person:
    def __init__(self,HoTen,NgaySinh,QueQuan,NganhHoc,NamTN):
        self._HoTen = HoTen
        self._NgaySinh = NgaySinh
        self._QueQuan = QueQuan
        self._NganhHoc = NganhHoc
        self._NamTN = NamTN

class KySu:
    DSKS = []
    def __init__(self):
        Person.__init__(self,HoTen,NgaySinh,QueQuan,NganhHoc,NamTN)

    def NhapKS(self):
        HoTen = input("Nhap Ho va Ten: ")
        NgaySinh = int(input("Nhap Ngay Sinh: "))
        QueQuan = input("Nhap Que Quan: ")
        NganhHoc = input("Nhap Nganh Hoc: ")
        NamTN = int(input("Nhap Nam Tot Nghiep: "))
        ps = Person(HoTen,NgaySinh,QueQuan,NganhHoc,NamTN)
        self.DSKS.append(ps)

    def Xuat(self,ps):
        stt = 0
        stt = stt+1
        print("{:<8} {:<20} {:<14} {:<14} {:<15} {:<8}"
              .format(stt,ps._HoTen, ps._NgaSinh, ps._QueQuan, ps._NganhHoc, ps._NamTN))

    def getDSKS(self):
        return self.DSKS

HoTen = 0
NgaySinh = 0
QueQuan = 0
NganhHoc = 0
NamTN = 0
Print = KySu()
print("----- Nhap Danh Sach Ky Su -----")
n = int(input("So luong Ky Su muon nhap: "))
for i in range(1,n+1):
    print("Nhap Ky Su thu ",i)
    i=i+1
    Print.NhapKS()
print("----- Danh Sach Ky Su -----")
print("{:<8} {:<20} {:<14} {:<14} {:<15} {:<8}"
      .format("STT","HoTen", "NgaySinh", "QueQuan", "NganhHoc", "NamTN"))
for i in range(1,n+1):
    Print.Xuat()