using System;
using System.Collections.Generic;
using System.Linq;

public class Equipment
{
    public string name;
    public string description;
    public int initial_distance;
    public int distance_moved;
    public int maintanence_cost;
    public int type;
};

class ExtEquipment
{
    public void create(List<Equipment> a)
    {
        Equipment ob = new Equipment();

        Console.WriteLine("Enter the name of the equipment");
        ob.name = Console.ReadLine();
        Console.WriteLine("Enter the description of the equipment");
        ob.description = Console.ReadLine();
        Console.WriteLine("Enter the initial distance moved by the equipment");
        ob.initial_distance = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter distance moved");
        ob.distance_moved = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the maintenance cost");
        ob.maintanence_cost = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the type of equipment 0 for mobile and 1 for immobile");
        ob.type = int.Parse(Console.ReadLine());

        a.Add(ob);
        Console.WriteLine("Item added to the list.\n");

        
    }

    public void delete(List<Equipment> a)
    {
        Console.WriteLine("Enter the equipment you want to delete");
        string s = Console.ReadLine();
        a.RemoveAll(x => x.name == s);
        Console.WriteLine("Item Deleted");
    }

    public void move_mobile(List<Equipment> a)
    {

        string s = Console.ReadLine();    //name
        string ss = Console.ReadLine();    //distance
        int d = int.Parse(ss);             //no of wheels
        string sss = Console.ReadLine();
        int w = int.Parse(sss);

        int len = a.Count;

        for (int i = 0; i < len; i++)
        {
            if (a[i].name == s)
            {
                a[i].distance_moved += d;
                a[i].maintanence_cost += (w * d);
                break;
            }
        }

    }

    public void move_immobile(List<Equipment> a)
    {

        string s = Console.ReadLine();    //name
        string ss = Console.ReadLine();    //distance
        int d = int.Parse(ss);             //weight
        string sss = Console.ReadLine();
        int w = int.Parse(sss);

        int len = a.Count;

        for (int i = 0; i < len; i++)
        {
            if (a[i].name == s)
            {
                a[i].distance_moved += d;
                a[i].maintanence_cost += (w * d);            //will implement it using linq later
                break;
            }
        }

    }

    public void show(List<Equipment> a)
    {
        Console.WriteLine("The created list is shown below"); 
        int len = a.Count;

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(a[i].name + "   "+ a[i].description+"   ");
            Console.WriteLine("-------------------");
        }
        Console.ReadKey();
    }

    public void display(List<Equipment> a)
    {

        Console.WriteLine("Enter name you want to display");
        string s = Console.ReadLine(); //name input

        var detail = a.Where(y => y.name == s);

        foreach (var x in detail)
        {
            Console.WriteLine(x.name);
            Console.WriteLine(x.description);
            Console.WriteLine(x.distance_moved);
            Console.WriteLine(x.maintanence_cost);
            Console.WriteLine(x.type);
        }
    }

    public void dis_all_mob(List<Equipment> a)
    {

        var detail = a.Where(y => y.type == 1);

        foreach (var x in detail)
        {
            Console.WriteLine(x.name);

        }

    }

    public void dis_all_immob(List<Equipment> a)
    {

        var detail = a.Where(y => y.type == 2);

        foreach (var x in detail)
        {
            Console.WriteLine(x.name);

        }

    }
    
    public void not_moved(List<Equipment> a)
    {

        var detail = a.Where(y => (y.distance_moved - y.initial_distance) == 0);

        foreach (var x in detail)
        {
            Console.WriteLine(x.name);

        }

    }

    public void delete_all(List<Equipment> a)
    {
        a.Clear();
    }


}






