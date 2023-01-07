namespace formUser;

public class User{
    public string fn{get;set;}
    public string ln{get;set;}
    public int mn{get;set;}
    public string email{get;set;}
    public  string pwd{get;set;}
    public string cnfpwd{get;set;}

    public User(string fn,string ln,string email, int mn, string pwd,string cnfpwd){
        this.fn=fn;
        this.ln=ln;
        this.email=email;
        this.pwd=pwd;
        this.cnfpwd=cnfpwd;
    }
}