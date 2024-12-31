using Microsoft.VisualBasic;

namespace Learning;

public class Opdracht17_4
{
    private string[] _ordersData = new string[]
    {
        "3x Frietje, 2x Frikandel, 1x Cola",
        "1x Frietje Speciaal, 2x Kroket, 1x Water, 3x Kaassoufflé",
        "2x Frietje, 1x Frikandel Speciaal, 2x Bier", "4x Kaassoufflé, 2x Cola",
        "2x Frietje Oorlog, 1x Frikandel, 1x Milkshake",
        "3x Kroket, 2x Frikandel, 1x Cola, 1x Frietje","1x Frietje, 3x Bitterballen, 2x Limoen",
        "2x Frietje Speciaal, 1x Frikandel, 2x Kroket",
        "4x Frikandel, 1x Frietje Groot","3x Frietje, 2x Kaassoufflé, 1x Milkshake Vanille",
        "2x Kroket, 1x Frikandel Speciaal, 2x Water",
        "1x Frietje Oorlog, 2x Cola, 3x Frikandel","2x Frietje, 1x Bier, 3x Bitterballen",
        "1x Frietje Groot, 2x Frikandel Speciaal, 1x Cola",
        "3x Kroket, 2x Frietje Speciaal, 1x Water"
    };

    //Ik dacht aan een List eerst want dat leek makkelijk maar is veel moeilijker omdat je later dan een method moet hebben waar het elke product van een order,
    //Maar toen dacht ik erover om een List van Lists te maken, met elke order wordt een list waar [0] het eerste product is [1] het tweede product etc.
    //toen dacht ik om een LinkedList te gebruiken maar dat maakt het moeilijk om een bepaalde element op te zoeken om te veranderen dus, een List van Lists lijkt het beste.
    
    private List<string> _order; // een order
    private List<List<string>> _orderList; // alle orders
    
    public Opdracht17_4()
    {
        _orderList = new List<List<string>>();
    }

    public void Run()
    {
        OrdersDataToList();
        PrintOrders();
    }

    //print alle orders
    public void PrintOrders()
    {
        //print alles uit _orderList
        foreach (List<string> order in _orderList)
        {
            Console.WriteLine(string.Join(",", order));
        }
    }

    //veranderd de Data naar _orderList
    public void OrdersDataToList()
    {
        string currentOrder;
        string[] tempProducts;
        int amountOfProducts;
        
        //Doet orders in orderList
        for (int i = 0; i < _ordersData.Length; i++)
        {
            _order = new List<string>();
            
            currentOrder = _ordersData[i];
            currentOrder = currentOrder.Trim();
            
            amountOfProducts = currentOrder.Split(',').Length;
            
            tempProducts = currentOrder.Split(',');
            
            //veranderd currentOrder naar producten en doet dit in de list _order
            for (int j = 0; j < amountOfProducts; j++)
            {
                _order.Add(tempProducts[j]);
            }
            _orderList.Add(_order);
        }
    }
    
}