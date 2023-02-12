/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DoiTienTe;

/**
 *
 * @author saotr
 */
public class TienTe {
    public String ma;
    public double giaMua;
    public double giaBan;
    private byte[] image;

    public TienTe() {
    }

    public TienTe(String ma, double giaMua, double giaBan, byte[] image) {
        this.ma = ma;
        this.giaMua = giaMua;
        this.giaBan = giaBan;
        this.image = image;
    }

    TienTe(String ma, double giaMua, double giaBan) {
        this.ma = ma;
        this.giaMua = giaMua;
        this.giaBan = giaBan;
    }


    public String getMa() {
        return ma;
    }

    public void setMa(String ma) {
        this.ma = ma;
    }

    public double getGiaMua() {
        return giaMua;
    }

    public void setGiaMua(double giaMua) {
        this.giaMua = giaMua;
    }

    public double getGiaBan() {
        return giaBan;
    }

    public void setGiaBan(double giaBan) {
        this.giaBan = giaBan;
    }

    public byte[] getImage() {
        return image;
    }

    public void setImage(byte[] image) {
        this.image = image;
    }
    
    
    
}
