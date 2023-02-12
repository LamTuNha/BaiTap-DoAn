/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DoiTienTe;

import javax.swing.Icon;
import javax.swing.table.AbstractTableModel;

/**
 *
 * @author saotr
 */
public class TheTable extends AbstractTableModel {

    private String[] column;
    private Object[][] rows;

    public TheTable() {
    }

    public TheTable(Object[][] data, String[] columnName) {
        this.rows = data;
        this.column = columnName;

    }
      public TheTable(Object[][] data) {
        this.rows = data;
    

    }
    @Override
    public Class getColumnClass(int column){
        if(column==0){
            return Icon.class;
        }
        else{
            return getValueAt(0,column).getClass();
        }
    }

    @Override
    public int getRowCount() {
        return this.rows.length;
    }

    @Override
    public int getColumnCount() {
        return this.column.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
     return this.rows[rowIndex][columnIndex];
    }
    
    @Override
    public String getColumnName(int col){
        return this.column[col];
    }

}
