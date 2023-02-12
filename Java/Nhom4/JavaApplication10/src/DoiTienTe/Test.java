/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DoiTienTe;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/**
 *
 * @author saotr
 */
public class Test {

    private static String layTyGia() throws MalformedURLException, IOException {
        URL tyGiaURl = new URL("https://www.dongabank.com.vn/exchange/export");
        URLConnection yc = tyGiaURl.openConnection();
        BufferedReader in = new BufferedReader(new InputStreamReader(yc.getInputStream()));
        String input = in.readLine();
       String output = input.replace("(", " ").replace(")", " ");//xoá 2 ngoặc tròn
        in.close();
        return output.trim();
    }

    public static void main(String[] args) throws MalformedURLException, IOException, JSONException {
         String data = layTyGia();
        JSONObject json = new JSONObject(data);
        JSONArray items = json.getJSONArray("items");

        for (int i = 0; i < items.length(); ++i) {
            JSONObject rec = items.getJSONObject(i);
            String type = rec.getString("type");
            String imageurl = rec.getString("imageurl");
            String muatienmat = rec.getString("muatienmat");
            String muack = rec.getString("muack");
            String bantienmat = rec.getString("bantienmat");
            String banck = rec.getString("banck");
            System.out.println(type+muatienmat+imageurl+muack);
        }
    }

}
