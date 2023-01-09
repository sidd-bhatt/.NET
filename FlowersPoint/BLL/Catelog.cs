namespace BLL;
using DAL;
using BOL;
public class Catelog{

    public List<Flower> GetFlower(){
        List<Flower> getAllFlower=DBManager.GetAllFlowers();//getting the details of flower from DAL
        return getAllFlower;
    }
}