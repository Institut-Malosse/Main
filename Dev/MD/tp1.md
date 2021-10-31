# TP1 LINUX CERT

## Identité :

Nous sommes l'institut Malosse, une association sous loi 1901 où le but est la propagande des systèmes GNU/Linux 
dits "élitistes" tels que Arch ou Gentoo.
Ce document a été réalisé par Julien Lefranc et Fabien Malosse, les membres fondateurs de l'institut Malosse.

## Temps de réalisation :

La réalisation de cette exercice a été faite sous un délai de 4H (arrondie à la 1/2H).

## Difficultés rencontrées :

Problème avec **SystemD** qui recherche le réseau lors du démarrage de la machine (**OpenRC** c'est quand même mieux que **SystemD** ^^).

## Utilisateurs :

> #### root :
>
> Mot de passe : GentooIsFarSuperior
>
> #### csia :
>
> Mot de passe : csia
>
> #### csiaweb :
>
> Mot de passe : csiaweb
>
> #### csiadb :
>
> Mot de passe : csiadb
>
> #### kgouny :
>
> Mot de passe : kgouny
>
> #### jlefranc :
>
> Mot de passe : juju
>

## Connexion :

La connexion est effective en ssh via l'ip **172.16.110.105** avec le port **22**.
L'utilisateur **root** n'est pas autorisé à se connecter en ssh sur la machine.

## Applications et scripts :

Le logiciel compilé ainsi que les scripts ont été placés dans **/srv/bin**, qui a été déclaré dans le **PATH**.
Les scipts ont également un lien symbolique pointant de /srv/bin à **/usr/bin**, permettant l'utilisation sans spécifier le .sh dans le terminal.