/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DoiTienTe;

import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableCellRenderer;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.JTableHeader;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 *
 * @author saotr
 */
public class NgoaiTte extends javax.swing.JFrame {

    DefaultTableModel model;
    ArrayList<TienTe> list;

    public NgoaiTte() throws IOException, JSONException {
        initComponents();
        list = new ArrayList<>();
        showResult();
    }

    public boolean isNumeric(String str) {
        try {
            Double.parseDouble(str);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jblHienThi = new javax.swing.JTable();
        button1 = new java.awt.Button();
        jHinhAnh = new javax.swing.JLabel();
        cbTienTe = new javax.swing.JComboBox<>();
        txtNgoaiTe = new javax.swing.JTextField();
        jHinhAnh1 = new javax.swing.JLabel();
        jHinhAnh2 = new javax.swing.JLabel();
        txtMua = new javax.swing.JTextField();
        txtBan = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jblHienThi.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Quốc kì", "Mã", "Giá", "Mua", "Bán"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.Byte.class, java.lang.Object.class, java.lang.Object.class, java.lang.Object.class, java.lang.Object.class
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }
        });
        jScrollPane1.setViewportView(jblHienThi);

        button1.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        button1.setLabel("Tính Tiền");
        button1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                button1ActionPerformed(evt);
            }
        });

        jHinhAnh.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jHinhAnh.setText("Nhập số ngoại tệ:");

        cbTienTe.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbTienTeActionPerformed(evt);
            }
        });

        jHinhAnh1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jHinhAnh1.setText("Loại ngoại tệ:");

        jHinhAnh2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jHinhAnh2.setText("Thành tiền VND:");

        txtMua.setEditable(false);
        txtMua.setText("Mua");

        txtBan.setEditable(false);
        txtBan.setText("Bán");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(70, 70, 70)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jHinhAnh1, javax.swing.GroupLayout.PREFERRED_SIZE, 156, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jHinhAnh, javax.swing.GroupLayout.PREFERRED_SIZE, 156, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jHinhAnh2, javax.swing.GroupLayout.PREFERRED_SIZE, 156, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(126, 126, 126)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(cbTienTe, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtMua, javax.swing.GroupLayout.DEFAULT_SIZE, 242, Short.MAX_VALUE)
                            .addComponent(txtBan)
                            .addComponent(txtNgoaiTe)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(176, 176, 176)
                        .addComponent(button1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(25, 25, 25)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 847, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(24, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 255, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(106, 106, 106)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jHinhAnh)
                    .addComponent(txtNgoaiTe, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(22, 22, 22)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jHinhAnh1)
                    .addComponent(cbTienTe, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(25, 25, 25)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jHinhAnh2)
                    .addComponent(txtMua, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(txtBan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(54, 54, 54)
                .addComponent(button1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(183, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void button1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_button1ActionPerformed
        if (isNumeric(txtNgoaiTe.getText()) == false) {
            JOptionPane.showMessageDialog(null, "Vui lòng nhập số tiền dạng số", "Error", JOptionPane.ERROR_MESSAGE);
        } else {

            for (TienTe tien : list) {
                if (tien.ma == cbTienTe.getSelectedItem()) {

                    txtMua.setText(String.valueOf(format_number(tien.giaMua * Double.parseDouble(txtNgoaiTe.getText()))));
                    txtBan.setText(String.valueOf(format_number(tien.giaBan * Double.parseDouble(txtNgoaiTe.getText()))));
                }
            }
        }
    }//GEN-LAST:event_button1ActionPerformed
    public static String format_number(double value) {
        DecimalFormat df = new DecimalFormat("###,###,###,###");
        return df.format(value);
    }
    private void cbTienTeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbTienTeActionPerformed


    }//GEN-LAST:event_cbTienTeActionPerformed

    public void showResult() throws IOException, JSONException {

        model = (DefaultTableModel) jblHienThi.getModel();
        String data = layTyGia();
        JSONObject json = new JSONObject(data);
        String[] column = {"Quốc kì", "Mã", "Giá mua tiền mặt", "Giá mua", "Giá bán"};
        JSONArray items = json.getJSONArray("items");
        Object[][] row = new Object[items.length()][5];

        for (int i = 0; i < items.length(); ++i) {
            TienTe tt = null;

            JSONObject rec = items.getJSONObject(i);
            //Get Image logo
            String imageurl = rec.getString("imageurl");
            URL url = new URL(imageurl);
            ImageIcon icon = new ImageIcon(new ImageIcon(url).getImage().getScaledInstance(30, 30, Image.SCALE_DEFAULT));
            row[i][0] = icon;

            String type = rec.getString("type");
            row[i][1] = type;

            String muatienmat = rec.getString("muatienmat");
            row[i][2] = muatienmat;

            String muack = rec.getString("muack");
            row[i][3] = muack;

            String banck = rec.getString("banck");
            row[i][4] = banck;
            cbTienTe.addItem(type);

            tt = new TienTe(type, Double.parseDouble(muack.toString()), Double.parseDouble(banck.toString()));
            list.add(tt);
        }
        JTableHeader head = jblHienThi.getTableHeader();
        ((DefaultTableCellRenderer) head.getDefaultRenderer()).setHorizontalAlignment(JLabel.CENTER);
        //model.addColumn(column, row);
        TheTable moTable = new TheTable(row, column);
        jblHienThi.setModel(moTable);

        jblHienThi.setRowHeight(50);
        jblHienThi.getColumnModel().getColumn(1).setPreferredWidth(150);

    }

    private String layTyGia() throws MalformedURLException, IOException {
        URL tyGiaURl = new URL("https://www.dongabank.com.vn/exchange/export");
        URLConnection yc = tyGiaURl.openConnection();
        BufferedReader in = new BufferedReader(new InputStreamReader(yc.getInputStream()));
        String input = in.readLine();
        String output = input.replace("(", " ").replace(")", " ");//xoá 2 ngoặc tròn
        in.close();
        return output.trim();
    }

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(NgoaiTte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(NgoaiTte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(NgoaiTte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(NgoaiTte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    new NgoaiTte().setVisible(true);
                } catch (IOException ex) {
                    Logger.getLogger(NgoaiTte.class.getName()).log(Level.SEVERE, null, ex);
                } catch (JSONException ex) {
                    Logger.getLogger(NgoaiTte.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private java.awt.Button button1;
    private javax.swing.JComboBox<String> cbTienTe;
    private javax.swing.JLabel jHinhAnh;
    private javax.swing.JLabel jHinhAnh1;
    private javax.swing.JLabel jHinhAnh2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jblHienThi;
    private javax.swing.JTextField txtBan;
    private javax.swing.JTextField txtMua;
    private javax.swing.JTextField txtNgoaiTe;
    // End of variables declaration//GEN-END:variables

}
