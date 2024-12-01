public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    
    public Address(){}
    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public void SetStreet(string street){
        _street = street;
    }
    public void SetCity(string city){
        _city = city;
    }
    public void SetState(string state){
        _state = state;
    }
    public void SetCountry(string country){
        _country = country;
    }

    public bool InUSA(){
        if( _country == "USA" || _country == "United States" || _country == "United States of America"){
            return true;
        }
        else{
            return false;
        }
    }

    public string DisplayAddress(){
        string wholeAddress = _street + "\n" + _city + ", " + _state + " " + _country;
        return wholeAddress; 
    }
}