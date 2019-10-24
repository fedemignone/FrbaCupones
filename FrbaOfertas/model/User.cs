using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.model
{
    

    class User
    {
        string username;
        string password;

        //Login, se encarga de sumar el intento fallido y  resetearlo
        bool Login()
        {
            return false;
        }

        //devuelve una lista con los permisos obtenidos desde los roles.
        /*puede que Usertype deje de ser un enum y pase a ser una clase abstracta
        que tiene como comprortamiento EndablePanel y se encarga de ir habilitando los paneles
        en el menu principal luego del logueo y ahora qe lo escribo le encuentro demaciado sentido asi
        que voy a hacer eso. Me acabo de comer 1500 calorias en galletitas por estres estan contentos?
             */
        List<UserType> GetPermissions()
        {
            return new List<UserType>();
        }


        //estas tres funciones deberian devolver una instancia de Los objetos pertenecientes a este usuario
        //la cual solo deberia irse a buscar una vez
        Client GetClient()
        {
            return null;
        }

        Provider GetProvider()
        {
            return null;
        }

        Admin GetAdmin()
        {
            return null;
        }

    


    }
}
