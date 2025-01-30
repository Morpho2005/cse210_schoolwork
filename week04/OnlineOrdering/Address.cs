public class Address{
    string _streatAddress;
    string _city;
    string _state;
    string _country;

    public Address(string streat, string city, string state, string country){
        _streatAddress = streat;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA(){
        if (_country.ToLower() == "usa"){
            return true;
        } else {
            return false;
        }
    }

    public string GetAddress(){
        return $"{_streatAddress} {_city}, {_state}, {_country}";
    }
}