u s i n g   S w i n G a m e S D K ;  
 / /   ' '   < s u m m a r y >  
 / /   ' '   T h e   m e n u   c o n t r o l l e r   h a n d l e s   t h e   d r a w i n g   a n d   u s e r   i n t e r a c t i o n s  
 / /   ' '   f r o m   t h e   m e n u s   i n   t h e   g a m e .   T h e s e   i n c l u d e   t h e   m a i n   m e n u ,   g a m e  
 / /   ' '   m e n u   a n d   t h e   s e t t i n g s   m , e n u .  
 / /   ' '   < / s u m m a r y >  
 c l a s s   M e n u C o n t r o l l e r   {  
          
         p r i v a t e   s t r i n g [ ]   _ m e n u S t r u c t u r e ;  
          
         p r i v a t e   c o n s t   i n t   M E N U _ T O P   =   5 7 5 ;  
          
         p r i v a t e   c o n s t   i n t   M E N U _ L E F T   =   3 0 ;  
          
         p r i v a t e   c o n s t   i n t   M E N U _ G A P   =   0 ;  
          
         p r i v a t e   c o n s t   i n t   B U T T O N _ W I D T H   =   7 5 ;  
          
         p r i v a t e   c o n s t   i n t   B U T T O N _ H E I G H T   =   1 5 ;  
          
         p r i v a t e   c o n s t   i n t   B U T T O N _ S E P   =   ( B U T T O N _ W I D T H   +   M E N U _ G A P ) ;  
          
         p r i v a t e   c o n s t   i n t   T E X T _ O F F S E T   =   0 ;  
          
         p r i v a t e   c o n s t   i n t   M A I N _ M E N U   =   0 ;  
          
         p r i v a t e   c o n s t   i n t   G A M E _ M E N U   =   1 ;  
          
         p r i v a t e   c o n s t   i n t   S E T U P _ M E N U   =   2 ;  
          
         p r i v a t e   c o n s t   i n t   M A I N _ M E N U _ P L A Y _ B U T T O N   =   0 ;  
          
         p r i v a t e   c o n s t   i n t   M A I N _ M E N U _ S E T U P _ B U T T O N   =   1 ;  
          
         p r i v a t e   c o n s t   i n t   M A I N _ M E N U _ T O P _ S C O R E S _ B U T T O N   =   2 ;  
          
         p r i v a t e   c o n s t   i n t   M A I N _ M E N U _ Q U I T _ B U T T O N   =   3 ;  
          
         p r i v a t e   c o n s t   i n t   S E T U P _ M E N U _ E A S Y _ B U T T O N   =   0 ;  
          
         p r i v a t e   c o n s t   i n t   S E T U P _ M E N U _ M E D I U M _ B U T T O N   =   1 ;  
          
         p r i v a t e   c o n s t   i n t   S E T U P _ M E N U _ H A R D _ B U T T O N   =   2 ;  
          
         p r i v a t e   c o n s t   i n t   S E T U P _ M E N U _ E X I T _ B U T T O N   =   3 ;  
          
         p r i v a t e   c o n s t   i n t   G A M E _ M E N U _ R E T U R N _ B U T T O N   =   0 ;  
          
         p r i v a t e   c o n s t   i n t   G A M E _ M E N U _ S U R R E N D E R _ B U T T O N   =   1 ;  
          
         p r i v a t e   c o n s t   i n t   G A M E _ M E N U _ Q U I T _ B U T T O N   =   2 ;  
          
         p r i v a t e   C o l o r   M E N U _ C O L O R   =   S w i n G a m e . R G B A C o l o r ( 2 ,   1 6 7 ,   2 5 2 ,   2 5 5 ) ;  
          
         p r i v a t e   C o l o r   H I G H L I G H T _ C O L O R   =   S w i n G a m e . R G B A C o l o r ( 1 ,   5 7 ,   8 6 ,   2 5 5 ) ;  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   H a n d l e s   t h e   p r o c e s s i n g   o f   u s e r   i n p u t   w h e n   t h e   m a i n   m e n u   i s   s h o w i n g  
         / /   ' '   < / s u m m a r y >  
         p u b l i c   s t a t i c   v o i d   H a n d l e M a i n M e n u I n p u t ( )   {  
                 M e n u C o n t r o l l e r . H a n d l e M e n u I n p u t ( M A I N _ M E N U ,   0 ,   0 ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   H a n d l e s   t h e   p r o c e s s i n g   o f   u s e r   i n p u t   w h e n   t h e   m a i n   m e n u   i s   s h o w i n g  
         / /   ' '   < / s u m m a r y >  
         p u b l i c   s t a t i c   v o i d   H a n d l e S e t u p M e n u I n p u t ( )   {  
                 b o o l   h a n d l e d ;  
                 h a n d l e d   =   M e n u C o n t r o l l e r . H a n d l e M e n u I n p u t ( S E T U P _ M E N U ,   1 ,   1 ) ;  
                 i f   ( ! h a n d l e d )   {  
                         M e n u C o n t r o l l e r . H a n d l e M e n u I n p u t ( M A I N _ M E N U ,   0 ,   0 ) ;  
                 }  
                  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   H a n d l e   i n p u t   i n   t h e   g a m e   m e n u .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < r e m a r k s >  
         / /   ' '   P l a y e r   c a n   r e t u r n   t o   t h e   g a m e ,   s u r r e n d e r ,   o r   q u i t   e n t i r e l y  
         / /   ' '   < / r e m a r k s >  
         p u b l i c   s t a t i c   v o i d   H a n d l e G a m e M e n u I n p u t ( )   {  
                 M e n u C o n t r o l l e r . H a n d l e M e n u I n p u t ( G A M E _ M E N U ,   0 ,   0 ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   H a n d l e s   i n p u t   f o r   t h e   s p e c i f i e d   m e n u .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " m e n u " > t h e   i d e n t i f i e r   o f   t h e   m e n u   b e i n g   p r o c e s s e d < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " l e v e l " > t h e   v e r t i c a l   l e v e l   o f   t h e   m e n u < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " x O f f s e t " > t h e   x o f f s e t   o f   t h e   m e n u < / p a r a m >  
         / /   ' '   < r e t u r n s > f a l s e   i f   a   c l i c k e d   m i s s e d   t h e   b u t t o n s .   T h i s   c a n   b e   u s e d   t o   c h e c k   p r i o r   m e n u s . < / r e t u r n s >  
         p r i v a t e   s t a t i c   b o o l   H a n d l e M e n u I n p u t ( i n t   m e n u ,   i n t   l e v e l ,   i n t   x O f f s e t )   {  
                 i f   ( S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ E S C A P E ) )   {  
                         E n d C u r r e n t S t a t e ( ) ;  
                         r e t u r n   t r u e ;  
                 }  
                  
                 i f   ( S w i n G a m e . M o u s e C l i c k e d ( M o u s e B u t t o n . L e f t B u t t o n ) )   {  
                         i n t   i ;  
                         f o r   ( i   =   0 ;   ( i    
                                                 < =   ( _ m e n u S t r u c t u r e [ m e n u ] . L e n g t h   -   1 ) ) ;   i + + )   {  
                                 / /   I s M o u s e O v e r   t h e   i ' t h   b u t t o n   o f   t h e   m e n u  
                                 i f   ( M e n u C o n t r o l l e r . I s M o u s e O v e r M e n u ( i ,   l e v e l ,   x O f f s e t ) )   {  
                                         M e n u C o n t r o l l e r . P e r f o r m M e n u A c t i o n ( m e n u ,   i ) ;  
                                         r e t u r n   t r u e ;  
                                 }  
                                  
                         }  
                          
                         i f   ( ( l e v e l   >   0 ) )   {  
                                 / /   n o n e   c l i c k e d   -   s o   e n d   t h i s   s u b   m e n u  
                                 E n d C u r r e n t S t a t e ( ) ;  
                         }  
                          
                 }  
                  
                 r e t u r n   f a l s e ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   D r a w s   t h e   m a i n   m e n u   t o   t h e   s c r e e n .  
         / /   ' '   < / s u m m a r y >  
         p u b l i c   s t a t i c   v o i d   D r a w M a i n M e n u ( )   {  
                 / /   C l e a r s   t h e   S c r e e n   t o   B l a c k  
                 / /   S w i n G a m e . D r a w T e x t ( " M a i n   M e n u " ,   C o l o r . W h i t e ,   G a m e F o n t ( " A r i a l L a r g e " ) ,   5 0 ,   5 0 )  
                 M e n u C o n t r o l l e r . D r a w B u t t o n s ( M A I N _ M E N U ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   D r a w s   t h e   G a m e   m e n u   t o   t h e   s c r e e n  
         / /   ' '   < / s u m m a r y >  
         p u b l i c   s t a t i c   v o i d   D r a w G a m e M e n u ( )   {  
                 / /   C l e a r s   t h e   S c r e e n   t o   B l a c k  
                 / /   S w i n G a m e . D r a w T e x t ( " P a u s e d " ,   C o l o r . W h i t e ,   G a m e F o n t ( " A r i a l L a r g e " ) ,   5 0 ,   5 0 )  
                 M e n u C o n t r o l l e r . D r a w B u t t o n s ( G A M E _ M E N U ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   D r a w s   t h e   s e t t i n g s   m e n u   t o   t h e   s c r e e n .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < r e m a r k s >  
         / /   ' '   A l s o   s h o w s   t h e   m a i n   m e n u  
         / /   ' '   < / r e m a r k s >  
         p u b l i c   s t a t i c   v o i d   D r a w S e t t i n g s ( )   {  
                 / /   C l e a r s   t h e   S c r e e n   t o   B l a c k  
                 / /   S w i n G a m e . D r a w T e x t ( " S e t t i n g s " ,   C o l o r . W h i t e ,   G a m e F o n t ( " A r i a l L a r g e " ) ,   5 0 ,   5 0 )  
                 M e n u C o n t r o l l e r . D r a w B u t t o n s ( M A I N _ M E N U ) ;  
                 M e n u C o n t r o l l e r . D r a w B u t t o n s ( S E T U P _ M E N U ,   1 ,   1 ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   D r a w   t h e   b u t t o n s   a s s o c i a t e d   w i t h   a   t o p   l e v e l   m e n u .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " m e n u " > t h e   i n d e x   o f   t h e   m e n u   t o   d r a w < / p a r a m >  
         p r i v a t e   s t a t i c   v o i d   D r a w B u t t o n s ( i n t   m e n u )   {  
                 M e n u C o n t r o l l e r . D r a w B u t t o n s ( m e n u ,   0 ,   0 ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   D r a w s   t h e   m e n u   a t   t h e   i n d i c a t e d   l e v e l .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " m e n u " > t h e   m e n u   t o   d r a w < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " l e v e l " > t h e   l e v e l   ( h e i g h t )   o f   t h e   m e n u < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " x O f f s e t " > t h e   o f f s e t   o f   t h e   m e n u < / p a r a m >  
         / /   ' '   < r e m a r k s >  
         / /   ' '   T h e   m e n u   t e x t   c o m e s   f r o m   t h e   _ m e n u S t r u c t u r e   f i e l d .   T h e   l e v e l   i n d i c a t e s   t h e   h e i g h t  
         / /   ' '   o f   t h e   m e n u ,   t o   e n a b l e   s u b   m e n u s .   T h e   x O f f s e t   r e p o s i t i o n s   t h e   m e n u   h o r i z o n t a l l y  
         / /   ' '   t o   a l l o w   t h e   s u b m e n u s   t o   b e   p o s i t i o n e d   c o r r e c t l y .  
         / /   ' '   < / r e m a r k s >  
         p r i v a t e   s t a t i c   v o i d   D r a w B u t t o n s ( i n t   m e n u ,   i n t   l e v e l ,   i n t   x O f f s e t )   {  
                 i n t   b t n T o p ;  
                 b t n T o p   =   ( M E N U _ T O P    
                                         -   ( ( M E N U _ G A P   +   B U T T O N _ H E I G H T )    
                                         *   l e v e l ) ) ;  
                 i n t   i ;  
                 f o r   ( i   =   0 ;   ( i    
                                         < =   ( _ m e n u S t r u c t u r e [ m e n u ] . L e n g t h   -   1 ) ) ;   i + + )   {  
                         i n t   b t n L e f t ;  
                         b t n L e f t   =   ( M E N U _ L E F T    
                                                 +   ( B U T T O N _ S E P    
                                                 *   ( i   +   x O f f s e t ) ) ) ;  
                         S w i n G a m e . D r a w T e x t L i n e s ( _ m e n u S t r u c t u r e [ m e n u ] [ i ] ,   M E N U _ C O L O R ,   C o l o r . B l a c k ,   G a m e F o n t ( " M e n u " ) ,   F o n t A l i g n m e n t . A l i g n C e n t e r ,   ( b t n L e f t   +   T E X T _ O F F S E T ) ,   ( b t n T o p   +   T E X T _ O F F S E T ) ,   B U T T O N _ W I D T H ,   B U T T O N _ H E I G H T ) ;  
                         i f   ( ( S w i n G a m e . M o u s e D o w n ( M o u s e B u t t o n . L e f t B u t t o n )   & &   M e n u C o n t r o l l e r . I s M o u s e O v e r M e n u ( i ,   l e v e l ,   x O f f s e t ) ) )   {  
                                 S w i n G a m e . D r a w R e c t a n g l e ( H I G H L I G H T _ C O L O R ,   b t n L e f t ,   b t n T o p ,   B U T T O N _ W I D T H ,   B U T T O N _ H E I G H T ) ;  
                         }  
                          
                 }  
                  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   D e t e r m i n e d   i f   t h e   m o u s e   i s   o v e r   o n e   o f   t h e   b u t t o n   i n   t h e   m a i n   m e n u .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " b u t t o n " > t h e   i n d e x   o f   t h e   b u t t o n   t o   c h e c k < / p a r a m >  
         / /   ' '   < r e t u r n s > t r u e   i f   t h e   m o u s e   i s   o v e r   t h a t   b u t t o n < / r e t u r n s >  
         p r i v a t e   s t a t i c   b o o l   I s M o u s e O v e r B u t t o n ( i n t   b u t t o n )   {  
                 r e t u r n   M e n u C o n t r o l l e r . I s M o u s e O v e r M e n u ( b u t t o n ,   0 ,   0 ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   C h e c k s   i f   t h e   m o u s e   i s   o v e r   o n e   o f   t h e   b u t t o n s   i n   a   m e n u .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " b u t t o n " > t h e   i n d e x   o f   t h e   b u t t o n   t o   c h e c k < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " l e v e l " > t h e   l e v e l   o f   t h e   m e n u < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " x O f f s e t " > t h e   x O f f s e t   o f   t h e   m e n u < / p a r a m >  
         / /   ' '   < r e t u r n s > t r u e   i f   t h e   m o u s e   i s   o v e r   t h e   b u t t o n < / r e t u r n s >  
         p r i v a t e   s t a t i c   b o o l   I s M o u s e O v e r M e n u ( i n t   b u t t o n ,   i n t   l e v e l ,   i n t   x O f f s e t )   {  
                 i n t   b t n T o p   =   ( M E N U _ T O P    
                                         -   ( ( M E N U _ G A P   +   B U T T O N _ H E I G H T )    
                                         *   l e v e l ) ) ;  
                 i n t   b t n L e f t   =   ( M E N U _ L E F T    
                                         +   ( B U T T O N _ S E P    
                                         *   ( b u t t o n   +   x O f f s e t ) ) ) ;  
                 r e t u r n   I s M o u s e I n R e c t a n g l e ( b t n L e f t ,   b t n T o p ,   B U T T O N _ W I D T H ,   B U T T O N _ H E I G H T ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   A   b u t t o n   h a s   b e e n   c l i c k e d ,   p e r f o r m   t h e   a s s o c i a t e d   a c t i o n .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " m e n u " > t h e   m e n u   t h a t   h a s   b e e n   c l i c k e d < / p a r a m >  
         / /   ' '   < p a r a m   n a m e = " b u t t o n " > t h e   i n d e x   o f   t h e   b u t t o n   t h a t   w a s   c l i c k e d < / p a r a m >  
         p r i v a t e   s t a t i c   v o i d   P e r f o r m M e n u A c t i o n ( i n t   m e n u ,   i n t   b u t t o n )   {  
                 s w i t c h   ( m e n u )   {  
                         c a s e   M A I N _ M E N U :  
                                 M e n u C o n t r o l l e r . P e r f o r m M a i n M e n u A c t i o n ( b u t t o n ) ;  
                                 b r e a k ;  
                         c a s e   S E T U P _ M E N U :  
                                 M e n u C o n t r o l l e r . P e r f o r m S e t u p M e n u A c t i o n ( b u t t o n ) ;  
                                 b r e a k ;  
                         c a s e   G A M E _ M E N U :  
                                 M e n u C o n t r o l l e r . P e r f o r m G a m e M e n u A c t i o n ( b u t t o n ) ;  
                                 b r e a k ;  
                 }  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   T h e   m a i n   m e n u   w a s   c l i c k e d ,   p e r f o r m   t h e   b u t t o n ' s   a c t i o n .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " b u t t o n " > t h e   b u t t o n   p r e s s e d < / p a r a m >  
         p r i v a t e   s t a t i c   v o i d   P e r f o r m M a i n M e n u A c t i o n ( i n t   b u t t o n )   {  
                 s w i t c h   ( b u t t o n )   {  
                         c a s e   M A I N _ M E N U _ P L A Y _ B U T T O N :  
                                 S t a r t G a m e ( ) ;  
                                 b r e a k ;  
                         c a s e   M A I N _ M E N U _ S E T U P _ B U T T O N :  
                                 A d d N e w S t a t e ( G a m e S t a t e . A l t e r i n g S e t t i n g s ) ;  
                                 b r e a k ;  
                         c a s e   M A I N _ M E N U _ T O P _ S C O R E S _ B U T T O N :  
                                 A d d N e w S t a t e ( G a m e S t a t e . V i e w i n g H i g h S c o r e s ) ;  
                                 b r e a k ;  
                         c a s e   M A I N _ M E N U _ Q U I T _ B U T T O N :  
                                 E n d C u r r e n t S t a t e ( ) ;  
                                 b r e a k ;  
                 }  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   T h e   s e t u p   m e n u   w a s   c l i c k e d ,   p e r f o r m   t h e   b u t t o n ' s   a c t i o n .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " b u t t o n " > t h e   b u t t o n   p r e s s e d < / p a r a m >  
         p r i v a t e   s t a t i c   v o i d   P e r f o r m S e t u p M e n u A c t i o n ( i n t   b u t t o n )   {  
                 s w i t c h   ( b u t t o n )   {  
                         c a s e   S E T U P _ M E N U _ E A S Y _ B U T T O N :  
                                 S e t D i f f i c u l t y ( A I O p t i o n . H a r d ) ;  
                                 b r e a k ;  
                         c a s e   S E T U P _ M E N U _ M E D I U M _ B U T T O N :  
                                 S e t D i f f i c u l t y ( A I O p t i o n . H a r d ) ;  
                                 b r e a k ;  
                         c a s e   S E T U P _ M E N U _ H A R D _ B U T T O N :  
                                 S e t D i f f i c u l t y ( A I O p t i o n . H a r d ) ;  
                                 b r e a k ;  
                 }  
                 / /   A l w a y s   e n d   s t a t e   -   h a n d l e s   e x i t   b u t t o n   a s   w e l l  
                 E n d C u r r e n t S t a t e ( ) ;  
         }  
          
         / /   ' '   < s u m m a r y >  
         / /   ' '   T h e   g a m e   m e n u   w a s   c l i c k e d ,   p e r f o r m   t h e   b u t t o n ' s   a c t i o n .  
         / /   ' '   < / s u m m a r y >  
         / /   ' '   < p a r a m   n a m e = " b u t t o n " > t h e   b u t t o n   p r e s s e d < / p a r a m >  
         p r i v a t e   s t a t i c   v o i d   P e r f o r m G a m e M e n u A c t i o n ( i n t   b u t t o n )   {  
                 s w i t c h   ( b u t t o n )   {  
                         c a s e   G A M E _ M E N U _ R E T U R N _ B U T T O N :  
                                 E n d C u r r e n t S t a t e ( ) ;  
                                 b r e a k ;  
                         c a s e   G A M E _ M E N U _ S U R R E N D E R _ B U T T O N :  
                                 E n d C u r r e n t S t a t e ( ) ;  
                                 / /   e n d   g a m e   m e n u  
                                 E n d C u r r e n t S t a t e ( ) ;  
                                 / /   e n d   g a m e  
                                 b r e a k ;  
                         c a s e   G A M E _ M E N U _ Q U I T _ B U T T O N :  
                                 A d d N e w S t a t e ( G a m e S t a t e . Q u i t t i n g ) ;  
                                 b r e a k ;  
                 }  
         }  
 } 