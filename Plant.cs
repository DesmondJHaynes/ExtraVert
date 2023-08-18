/*
Remember! 
It's just an ERD, so instead of table NameOfTable{}... 
    > it's class NameOfTable{} && make it public!
    > Also NO COMMAS NO; NO ='s; No COLONSs NECESSARY 
*/
public class Plant
{
    public string Species { get; set; }
    public int LightNeeds { get; set; }
    public decimal AskingPrice { get; set; }
    public string City { get; set; }
    public int ZIP { get; set; }
    public bool Sold { get; set; }

}