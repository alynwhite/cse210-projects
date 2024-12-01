public class Product{
    private string _name;
    private string _product_id;
    private int _quantity;
    private double _price;

    public Product(){}
    public Product(string name, string product_id, int quantity, double price){
        _name = name;
        _product_id = product_id;
        _quantity = quantity;
        _price = price;
    }
    public void SetName(string name){
        _name = name;
    }
    public void SetID(string id){
        _product_id = id;
    }
    public void SetQuantity(int quantity){
        _quantity = quantity;
    }
    public void SetPrice(double price){
        _price = price;
    }
    public string GetProductName(){
        return _name;
    }

    public string GetProductID(){
        return _product_id;
    }

    public double GetTotalCost(){
        return _price *(double)_quantity;
    }
}