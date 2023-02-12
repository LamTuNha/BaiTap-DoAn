class Sohoc:
    so1=0
    so2=0
    def __init__(self,a=0,b=0):
        self.so1=a
        self.so2=b

    def nhap(self,so1,so2):
        self.so1=float(input("Nhap number 1: "))
        self.so2=float(input("Nhap number 2: "))
    def _so1(self):
        return self.so1
    def _so2(self):
        return self.so2

    def Cong(self,so1,so2 ):
        cong = self.so1 +self.so2
        return cong

    def Xuat(self,):
        print("Number 1: ",self.so1)
        print("Number 2: ",self.so2)
        print("Cong: ", self.Cong(self.so1,self.so2))

a=0
b=0
so= Sohoc()
so.nhap(a,b)
so.Xuat()
