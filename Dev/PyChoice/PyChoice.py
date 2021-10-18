from os import system, name
import random
import time
def clear():
    if name == 'nt':
        _ = system('cls')
    else:
        _ = system('clear')

def roulette(): 
    for i in range (25) :
        print(random.choice(listeOS)) ;
        time.sleep(0.001) ;
        clear() ;
    for i in range (10) :
        print(random.choice(listeOS)) ;
        time.sleep(0.01) ;
        clear() ;
    for i in range (5) :
        print(random.choice(listeOS)) ;
        time.sleep(0.1) ;
        clear() ;
    for i in range (3) :
        print(random.choice(listeOS)) ;
        time.sleep(0.5) ;
        clear() ;
    ROS = random.choice(listeOS)
    print(ROS) ;
    print("L'OS choisit sera donc : " + ROS) ;

continuer = "y" ;
listeOS = [] ;
while (continuer == "y" or continuer == "yes" or continuer == "oui" or continuer == "o") :
    listeOS.append(input("Ecris le nom d'un OS à ajouter : ")) ;
    continuer = input("Veux-tu ajouter un OS ? (yes/no ; y/n ; oui/non ; o/n) : " ) ;
    while (continuer !="yes" and continuer !="no" and continuer !="y" and continuer !="n" and continuer !="oui" and continuer !="non" and continuer !="o" ) :
        continuer = input("Erreur de syntax, Veux-tu ajouter un OS ? (yes/no ; y/n ; oui/non ; o/n : " ) ;
print("Voici ta liste d'OS : ") ;
print(*listeOS, sep = ", ") ;
print("Lancement du tirage au sort");
print(".");
time.sleep(1) ;
print(".");
time.sleep(1) ;
print(".");
time.sleep(1) ;
print(".");
clear() ;
roulette();
input("Appuyer sur Retour Chariot pour quitter ;)")