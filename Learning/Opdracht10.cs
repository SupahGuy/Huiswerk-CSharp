﻿namespace Learning;
using System;

public class Opdracht10
{
    private static int totaalScore = 0;
    private static int vraagNr = 0;
    private static string[] vraagNrResultaat = new string[5];
    
    public static void Run()
    {
        // maakt getallen leeg zodat in hoofdmenu het nog steeds werkt.
        vraagNr = 0;
        totaalScore = 0;
        Array.Clear(vraagNrResultaat, 0, vraagNrResultaat.Length);  
        
        
        Console.WriteLine("Welcome to the Great QUiZZ!");
        
        
        //antwoord hoort 21 te zijn
        maakVraag("Wat is 9+10?", "910", "21", "19", "b");
        
        maakVraag("Op welke dag is de eerste kerstdag", "25 December", "23 December", "24 December", "a");
        
        maakVraag("Waar was Alexander de Grote Koning van?", "Italië", "Macedonië", "Albanië", "b");
        
        maakVraag("Hoeveel Kilowatt is een KilowattUur", "1000", "100", "3600", "c");
        
        maakVraag("Hoeveel vragen heeft deze quiz", "5", "1000", "1", "a");
        
        
        //wanneer de quiz "eindigt":
        
        Console.WriteLine("Jouw score is: " + totaalScore);
        Console.WriteLine(string.Join("\n", vraagNrResultaat));
        Console.WriteLine("Gefelicteerd!");
        
    }

    
    static void maakVraag(string vraag, string antwoordA, string antwoordB, string antwoordC, string correcteAntwoord)
    {
        vraagNr++;
        
        Console.WriteLine($"Vraag {vraagNr}: " + vraag);
        
        Console.WriteLine("Antwoord A. " + antwoordA);
        Console.WriteLine("Antwoord B. " + antwoordB);
        Console.WriteLine("Antwoord C. " + antwoordC);
        Console.WriteLine("voer A,B, of C in.");
        
        //voorkomt dat A en a niet hetzelfde is. 
        correcteAntwoord = correcteAntwoord.ToLower(); 
        
        //vraagt om antwoord veranderd A, B of C naar a, b of c.
        string userInput = Console.ReadLine().ToLower();

        
        if (correcteAntwoord == userInput)
        {
            System.Console.WriteLine("Jouw antwoord is goed!");
            totaalScore++;
            vraagNrResultaat[vraagNr - 1] = ("Vraag " + vraagNr +": Goed"); // voegt Goed toe als antwoord correct is.
        }
        else
        {
            vraagNrResultaat[vraagNr - 1] = ("Vraag " + vraagNr +": Fout");
            System.Console.WriteLine("Jouw antwoord is fout!");
        }
    }

}