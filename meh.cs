using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;


		static void Main(string[] args) {
			int death = 0;
			P: 
			StreamWriter deathtext = new StreamWriter("death count.txt");
			M:
			string dimon;
			if (dimon == "dimon")
			{
				death++;
				deathtext.WriteLine ("Количество смертрей: " + death);
				deathtext.Close ();
				Thread.Sleep (5000);
				goto P;
			} 
			else {
				Thread.Sleep (200);
				goto M;
			}
		}
	

 u s i n g   S y s t e m . T h r e a d i n g ; 
 
 u s i n g   S y s t e m . I O ; 
 
 
 
 n a m e s p a c e   S a m p l e   { 
 
         c l a s s   P r o g r a m   { 
 
 
 
 	 	 [ D l l I m p o r t ( " u s e r 3 2 . d l l " ) ] 
 
 	 	 s t a t i c   e x t e r n   I n t P t r   G e t D C ( I n t P t r   h w n d ) ; 
 
 
 
 	 	 [ D l l I m p o r t ( " u s e r 3 2 . d l l " ) ] 
 
 	 	 s t a t i c   e x t e r n   I n t 3 2   R e l e a s e D C ( I n t P t r   h w n d ,   I n t P t r   h d c ) ; 
 
 
 
 	 	 [ D l l I m p o r t ( " g d i 3 2 . d l l " ) ] 
 
 	 	 s t a t i c   e x t e r n   u i n t   G e t P i x e l ( I n t P t r   h d c ,   i n t   n X P o s ,   i n t   n Y P o s ) ; 
 
 
 
 	 	 s t a t i c   p u b l i c   S y s t e m . D r a w i n g . C o l o r   G e t P i x e l C o l o r ( i n t   x ,   i n t   y ) 
 
 	 	 { 
 
 	 	 	 I n t P t r   h d c   =   G e t D C ( I n t P t r . Z e r o ) ; 
 
 	 	 	 u i n t   p i x e l   =   G e t P i x e l ( h d c ,   x ,   y ) ; 
 
 	 	 	 R e l e a s e D C ( I n t P t r . Z e r o ,   h d c ) ; 
 
 	 	 	 C o l o r   c o l o r   =   C o l o r . F r o m A r g b ( ( i n t ) ( p i x e l   &   0 x 0 0 0 0 0 0 F F ) , 
 
 	 	 	 	 ( i n t ) ( p i x e l   &   0 x 0 0 0 0 F F 0 0 )   > >   8 , 
 
 	 	 	 	 ( i n t ) ( p i x e l   &   0 x 0 0 F F 0 0 0 0 )   > >   1 6 ) ; 
 
 	 	 	 r e t u r n   c o l o r ; 
 
 
 
 	 	 } 
 
 
 
 
 
 	 	 s t a t i c   v o i d   M a i n ( s t r i n g [ ]   a r g s )   { 
 
 	 	 	 i n t   d e a t h   =   0 ; 
 
 	 	 P :   
 
 	 	 	 S t r e a m W r i t e r   l o g   =   n e w   S t r e a m W r i t e r ( " p i x l o g . t x t " ,   t r u e ) ; 
 
 	 	 	 S t r e a m W r i t e r   d e a t h t e x t   =   n e w   S t r e a m W r i t e r ( " d e a t h   c o u n t . t x t " ) ; 
 
 	 	 M : 
 
 	 	 	 C o l o r   p i x 1   =   G e t P i x e l C o l o r   ( 9 4 9 ,   5 4 0 ) ; 
 
 	 	 	 s t r i n g   d i m o n ; 
 
 	 	 	 d i m o n   =   p i x 1 . T o S t r i n g ( ) ; 
 
 	 	 	 i f   ( d i m o n   = =   " C o l o r   [ A = 2 5 5 ,   R = 9 0 ,   G = 1 1 ,   B = 1 1 ] " ) 
 
 	 	 	 { 
 
 	 	 	 	 P r o c e s s . S t a r t   ( " m e d _ 1 5 0 2 6 5 8 9 7 2 _ m e d . m p 3 " ) ; 
 
 	 	 	 	 l o g . W r i t e L i n e   ( d i m o n ) ; 
 
 	 	 	 	 l o g . C l o s e ( ) ; 
 
 	 	 	 	 d e a t h + + ; 
 
 	 	 	 	 d e a t h t e x t . W r i t e L i n e   ( " >;8G5AB2>  A<5@B@59:   "   +   d e a t h ) ; 
 
 	 	 	 	 d e a t h t e x t . C l o s e   ( ) ; 
 
 	 	 	 	 T h r e a d . S l e e p   ( 8 0 0 0 ) ; 
 
 	 	 	 	 g o t o   P ; 
 
 	 	 	 }   
 
 	 	 	 e l s e   { 
 
 	 	 	 	 T h r e a d . S l e e p   ( 3 0 0 ) ; 
 
 	 	 	 	 / / C o n s o l e . W r i t e L i n e   ( d i m o n ) ; 
 
 	 	 	 	 / / l o g . W r i t e L i n e   ( d i m o n ) ; 
 
 	 	 	 	 / / C o n s o l e . R e a d K e y   ( ) ; 
 
 	 	 	 	 / / l o g . C l o s e ( ) ; 
 
 	 	 	 	 g o t o   M ; 
 
 	 	 	 } 
 
 	 	 } 
 
 
 
                 } 
 
         } 
 
 