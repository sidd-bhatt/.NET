namespace BOL;
public class Flower
{

    public int FlowerId{get;set;}
    public string Title{get;set;}
    public string Category{get;set;}
    public string Description{get;set;}
    public float UnitPrice{get;set;}
    public int Balance{get;set;}


     public Flower(){
    }

     public Flower(int FlowerId, string title, string description, float unitPrice, string category, int balance){
        this.FlowerId = FlowerId;
        this.Title = title;
        this.Category = category;
        this.UnitPrice = unitPrice;
        this.Balance = balance;
        this.Description = description;
    }
    
}