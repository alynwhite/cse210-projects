public class Customer{
    private string _name;
    private Address _address;

    public Customer(Address a1){
        _address = a1;
    }
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public void SetName(string name){
        _name = name;
    }

    public string GetCustomerName(){
        return _name;
    }

    public string GetAddress(){
        return _address.DisplayAddress();
    }

    public bool CheckUSA(){
        return _address.InUSA();
    }
}