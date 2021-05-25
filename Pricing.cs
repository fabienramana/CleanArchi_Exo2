namespace RCorpFoodPricer
{
    using System;

    public class App
    {
        
        //calcule le prix payé par l'utilisateur dans le restaurant, en fonction de type de 
        //repas qu'il prend (assiette ou sandwich), de la taille de la boisson (petit, moyen, grand), du dessert et
        //de son type (normal ou special) et si il prend un café ou pas (yes ou no).
        //les prix sont fixes pour chaque type de chose mais des réductions peuvent s'appliquer
        //si cela rentre dans une formule!
        public double Compute(string type, string name, string beverage, string size, string dessert, string dsize, string coffee)
        {
            //prix total à payer pour le client
            int total = 0;
            
            //le type ne peut être vide car le client doit déclarer au moins un repas
            if(string.IsNullOrEmpty(type+name)) return -1;
            
            total += getMealTypePrice(type);
            total += getDrinkTypePrice(size);
            total += getDessertTypePrice(dsize);


            switch(type){
                case "assiette":
                    if(size == "moyen" && dsize == "normal"){
                        total = 18;
                    }
                    else if (size == "grand" && dsize == "special"){
                        total = 21;
                    }
                    break;

                case "sandwich":
                    if(size == "moyen" && dsize == "normal"){
                        total = 13;
                    }
                    else if (size == "grand" && dsize == "special"){
                        total = 16;
                    }
                    break;
            }

            if(type=="assiette" && size=="moyen" && dsize=="normal" && coffee=="yes"){
                Console.Write(" avec café offert!");
            }else{
                total += getCoffeePrice(coffee);
            }

            return total;
        }


        public int getMealTypePrice(string mealType){
            if(mealType == "assiette"){
                return 15;
            }
            return 10;
        }

        public int getDrinkTypePrice(string drinkType){
            if(drinkType == "petit"){
                return 2;
            }
            else if (drinkType == "moyen"){
                return 3;
            }
            return 4;
        }

        public int getDessertTypePrice(string dessertType){
            if(dessertType == "normal"){
                return 2;
            }
            return 4;
        }

        public int getCoffeePrice(string coffee){
            if(coffee == "yes"){
                return 1;
            }
            return 0;
        }

    }