using System.Linq.Expressions;

public class Order{
    private List<Product> _product = new List<Product>();
    private Customer _customer;
    public Order(Customer c1){
        _customer = c1;
    }
    public Order(Product product, Customer customer){
        AddToProduct(product);
        _customer = customer;
    }

    public void AddToProduct(Product product){
        _product.Add(product);
    }
    public double CalculateTotalCost(){
        double sumOfTotal = 0;
        for(int i = 0; i < _product.Count; i++){
            sumOfTotal += _product[i].GetTotalCost();
        }
        sumOfTotal += CheckUSA();
        return sumOfTotal;
    }

    public string GetPackingLabel(){
        string packingLabel = "";
        packingLabel += "Product Id   |   Product Name\n - - - - - - - - - - - - - - - - - - - ";

        for(int i = 0; i < _product.Count; i++){
            packingLabel +=_product[i].GetProductID() + "  |   " + _product[i].GetProductName();
        }
        return packingLabel;
    }

    public string GetShippingLabel(){
        return "To: "+ _customer.GetCustomerName()  + "\n" + _customer.GetAddress();
    }

    public double CheckUSA(){
        if (_customer.CheckUSA() == true){
            return 5.0;
        }
        else{
            return 15.0;
        }
    }

}