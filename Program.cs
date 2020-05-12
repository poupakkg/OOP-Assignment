using System;

namespace ArtGallery
{ //encapsuation method
    class Painting
    {
        private string paintingName;
        private string artistName; 
        private string medium; 
        private int paintingYear; 
        
        public string paintingName1
        {//accessor
            get {return paintingName;}
            set {paintingName = value;}
        }
        public string artistName1
        { // accessor
            get { return artistName;}
            set { artistName = value;}
         }
         public string medium1
         { // accessor
            get { return medium;}
            set { medium = value;}
         }
         public int paintingYear1
         { // accessor
            get { return paintingYear;}
            set { paintingYear = value;}
         }
        public void greet()
        {
          Console.WriteLine("WELCOME TO THE ART GALLERY!");
        }
    }
    // inheritance , abstraction
    class value : Painting
    { // Painting value ($CAD)
        //public int paintingValue = 3500;
        abstract class PaintingValue
        {
            public void PaintingValue1()
            {
                Console.WriteLine("This Painting Value is: ");
            }
        }
    }
    // polymorphism
    class Style   
    { // Realism, Impressionism ,Painterly
        public virtual void styleName()
        
            {
                Console.WriteLine("[Insert Painting Style]");
            }
    }
     class Realism : Style
     {
         public override void styleName()
         {
             Console.WriteLine("The Horse Fair");
         }
     }
     class Impressionism :Style
     {
        public override void styleName()
         {
             Console.WriteLine("Vase with Fifteen Sunflowers");
         }
     }
    class Program
    {
            static void Main(string[] args)
        {
                Painting newPainting = new Painting();

                    newPainting.paintingName1 = "Vase with Fifteen Sunflowers";
                    newPainting.artistName1 = "Vincent van Gogh";
                    //newPainting.paintingValue1 = xxxxxx;
                    //newPainting.styleName = "";
                    newPainting.medium1 = "oil on canvas";
                    newPainting.paintingYear1 = 1889;

                    newPainting.paintingName1 = "The Horse Fair";
                    newPainting.artistName1 = "Rosa Bonheur";
                    newPainting.medium1 = "oil on canvas";
                    newPainting.paintingYear1 = 1852;

                    Console.WriteLine("Painting name is: " + newPainting.paintingName1);
                    Console.WriteLine("Painted in year " + newPainting.paintingYear1);
                    Console.WriteLine("by " + newPainting.artistName1);
                    Console.WriteLine("This Paiting is oil on canvas");
                }
            }  
}
        
 


    


