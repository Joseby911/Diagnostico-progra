

package palindromo;
import java.util.*;
import javax.swing.JOptionPane;

public class Palindromo {


    public static void main(String[] args) {
        
        int calculos=0;
        Scanner lectortexto = new Scanner (System.in);
        String cadenarepeticion = "";
        char [] cadenadearray;
    char caracter;
    int contador=0;
        
        do {            
            calculos=Integer.parseInt(JOptionPane.showInputDialog(null,"digitar la opcion a realizar:\n "+
                    "1-palindromo \n"+
                    "2- repetir \n"+ 
                    "3- salir"));
            
            switch(calculos){
                
                    case 1:
                        Scanner teclado= new Scanner(System.in);
                        String nuevo;
                        palindromo2 objclass=new palindromo2();
                        System.out.println("Ingresa la palabra");
                        nuevo = teclado.nextLine();
                        if(objclass.espalindromo(nuevo)){
                            System.out.println("Palindromo");
                        }
                        else
                        {
                            System.out.println("No Palindromo");
                        }
                    break;
                    case 2:
                      System.out.println ("Ingrese un texto: ");
                    cadenarepeticion = lectortexto.nextLine();
                    cadenadearray = cadenarepeticion.toCharArray();
                    for (int i = 0; i < cadenadearray.length; i++){
                    caracter = cadenadearray [i];

                    for (int j = 0; j <cadenadearray.length; j++){
                     if (cadenadearray[j] == caracter) {
                     contador++;

        }
    }

    System.out.println(cadenadearray[i]+ ""+ contador);
    contador = 0;

}
                        
                    break;
                    case 3: JOptionPane.showMessageDialog(null, "saliendo"); System.exit(0);break;
                    default: JOptionPane.showMessageDialog(null, "valor numerico invalido","error", JOptionPane.WARNING_MESSAGE);
                
            }
               
                    
        } while (calculos!=3);
        
        
        
    }
    
}
