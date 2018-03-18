;; HUMAN DISEASE DIAGNOSIS EXPERT SYSTEM
;; 2018-02-14
;; Indushree Murthy

(deftemplate carro
        (slot modelo)
        (slot precio )
        (slot tamano )
        (slot caballos )
        (slot abs )
        (slot consumo )
)
(deftemplate preferencias      
        (slot precio (default 13000)(type INTEGER))
        (slot tamano (default g))
        (slot caballos (default 79))
        (slot abs (default s))
        (slot consumo (default 9))
)

(deftemplate UI-control      
        (slot id)
        (slot message)        
)

;; defrules determinacion
(defrule modelo-1       
        (preferencias(precio ?x)(abs n)(tamano p)(caballos ?ca)(consumo ?co))
        (test(< ?x 12500))
        (test(< ?ca 80))
        (test(< ?co 4.9))
        => 
        (assert (UI-control (id 1)(message "El carro que usted necesita es el modelo 1")))
       ; (printout t "El carro que usted necesita es el modelo 1" crlf)
)

(defrule modelo-2
        (preferencias (precio ?x)(tamano p)(caballos ?ca)(abs s)(consumo ?co))        
        (test(> ?x 12499)) (test(< ?x 13000))
        (test(> ?ca 79))(test(< ?ca 100))
        (test(> ?co 4.8))(test(< ?co 6.0))
        => 
        (assert (UI-control (id 1)(message "El carro que usted necesita es el modelo 2")))
        ;(printout t "El carro que usted necesita es el modelo 2" crlf)
)
(defrule modelo-3
        (preferencias (precio ?x)(tamano m)(caballos ?ca)(abs s)(consumo ?co))        
        (test(> ?x 12999)) (test(< ?x 14000))
        (test(> ?ca 99))(test(< ?ca 125))
        (test(> ?co 7.7))(test(< ?co 8.5))        
        => 
        (assert (UI-control (id 1)(message "El carro que usted necesita es el modelo 3")))
        ;(printout t "El carro que usted necesita es el modelo 3" crlf)
)
(defrule modelo-4
        (preferencias (precio ?x)(tamano g)(caballos ?ca)(abs s)(consumo ?co))        
        (test(> ?x 13999)) (test(< ?x 15000))
        (test(> ?ca 124))(test(< ?ca 147))
        (test(> ?co 5.9))(test(< ?co 7.8))        
        => 
        (assert (UI-control (id 1)(message "El carro que usted necesita es el modelo 4")))
        ;(printout t "El carro que usted necesita es el modelo 4" crlf)
)
(defrule modelo-4-1
        (preferencias (precio ?x)(tamano g)(caballos ?ca)(abs s)(consumo ?co))        
        (test(> ?x 12000)) (test(< ?x 15000))
        (test(> ?ca 65))(test(< ?ca 147))
        (test(> ?co 4.7))(test(< ?co 7.8))        
        => 
        (assert (UI-control (id 1)(message "El carro que usted necesita es el modelo 4")))
        ;(printout t "El carro que usted necesita es el modelo 4" crlf)
)
(defrule modelo-5
        (preferencias (precio ?x)(tamano p)(caballos ?ca)(abs s)(consumo ?co))        
        (test(> ?x 14999)) 
        (test(> ?ca 146))
        (test(> ?co 8.4))
        => 
        (assert (UI-control (id 1)(message "El carro que usted necesita es el modelo 5")))
        ;(printout t "El carro que usted necesita es el modelo 5" crlf)        
 
)