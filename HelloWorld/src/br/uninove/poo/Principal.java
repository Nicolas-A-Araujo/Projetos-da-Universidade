package br.uninove.poo;

import java.util.Scanner;

public class Principal {
  
    public static void main(String[] args) {
        System.out.println("Ola dia");
        System.out.println("Ola vida");
        
        //declaração de variaveis:
        String nome = "Thiago Traue"; //string serve para textos
        int idade = 34; //int serve para numeros inteiros
        boolean fumante = false; //boolean serve para variaveis logicas
        float altura = 1.83f; //float serve para numeros reais
        char sexo = 'm'; //caracteres
        
        
        //Desvio incodicional
        //If sempre trabalha com condicoes boleanas
        if(fumante){//se
            System.out.println("Ah legal, voce e fumante");
        }else {//senao
            System.out.println("Show voce nao fuma, viva proerd");
        }     
    
        System.out.println(fumante ? "Fuma muito noia" : "Nao fuma, proerd");
        
        Scanner sc = new Scanner(System.in);
        System.out.println("Informe seu nome");
        nome = sc.nextLine();
        
        System.out.println("Informe sua idade");
        idade = sc.nextInt();
        
        System.out.println("Informe sua altura");
        altura = sc.nextFloat();
        
        System.out.println("Informe seu sexo");
        sexo = sc.next().charAt(0);
        
        System.out.println("meu nome é " + nome);
        System.out.println("Eu tenho " + idade);
        System.out.println("Show voce tem " +altura + "de altura");
        System.out.println("Sexo declarado " + sexo);
        
    }    
}
