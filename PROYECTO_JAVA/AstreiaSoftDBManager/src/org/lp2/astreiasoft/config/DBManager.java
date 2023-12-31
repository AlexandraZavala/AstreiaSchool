package org.lp2.astreiasoft.config;

import java.sql.Connection;
import java.sql.DriverManager;
public class DBManager {
    private Connection con;
    private static DBManager dbManager = new DBManager();
    private String url = "jdbc:mysql://"+
            "lp2-inf282-2023-2.cswj8lx2dbbn.us-east-1.rds.amazonaws.com" 
            + ":3306/" + "inf282?useSSL=false";
    private String username = "master";
    private String password = "lp2labsinf282";
    
    public Connection getConnection(){
        try{
            //Registrar el Driver JDBC
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexión con la BD
            con = DriverManager.getConnection(url, username, password);
            System.out.println("Se ha establecido la conexion con la BD");
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if (dbManager == null) {
            createInstance();
        }
        return dbManager;
    }
    
    private synchronized static void createInstance() {
        if (dbManager == null) {
            dbManager = new DBManager();
        }
    }
}
