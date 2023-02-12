class Person:
    def __init__(self,HoTen=0,NgaySinh=0,QueQuan=0):
        self.HT = HoTen
        self.NS = NgaySinh
        self.QQ = QueQuan

class KySu:
    def __init__(self,NganhHoc=0,NamTN=0):
        Person.__init__(self,HoTen,NgaySinh,QueQuan)
        self.NH = NganhHoc
        self.NTN = NamTN

    def NhapKS(self,HT,NS,QQ,NH,NTN):
        self.HT = input("Nhap Ho va Ten: ")
        self.NS = int(input("Nhap Ngay Sinh: "))
        self.QQ = input("Nhap Que Quan: ")
        self.NH = input("Nhap Nganh Hoc: ")
        self.NTN = int(input("Nhap Nam Tot Nghiep: "))


    def Xuat(self):
        stt = 0
        stt = stt+1
        print("{:<8} {:<20} {:<14} {:<14} {:<15} {:<8}"
              .format(stt,self.HT, self.NS, self.QQ, self.NH, self.NTN))

HoTen = 0
NgaySinh = 0
QueQuan = 0
NganhHoc = 0
NamTN = 0
Print = KySu()
DSKS = []
print("----- Nhap Danh Sach Ky Su -----")
n = int(input("So luong Ky Su muon nhap: "))
for i in range(1,n+1):
    print("Nhap Ky Su thu ",i)
    i=i+1
    DSKS.append(Print.NhapKS(HoTen,NgaySinh,QueQuan,NganhHoc,NamTN))
print("----- Danh Sach Ky Su -----")
print("{:<8} {:<20} {:<14} {:<14} {:<15} {:<8}"
      .format("STT","HoTen", "NgaySinh", "QueQuan", "NganhHoc", "NamTN"))
for i in range(1,n+1):
    Print.Xuat()