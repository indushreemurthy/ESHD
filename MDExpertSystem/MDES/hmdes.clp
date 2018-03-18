;; HUMAN DISEASE DIAGNOSIS EXPERT SYSTEM
;; 2018-02-14
;; Indushree Murthy

(deftemplate diagnosis
        (slot disease)
        (slot gender )
        (slot age )
        (slot weight )
        (slot fever )
        (slot symptom1 )
		(slot symptom2 )
)
(deftemplate preference      
        (slot gender (default 2))
        (slot age (default 1))
        (slot weight (default 1))
        (slot fever (default y))
        (slot symptom1 (default 1))
		(slot symptom2 (default 1))
)

(deftemplate UI-control      
        (slot id)
        (slot message)        
)

;; defrules determination
(defrule disease-1       
        (preference (gender ?g)(fever n)(age 1)(weight ?w)(symptom1 ?s1)(symptom2 ?s2))
		(test(eq ?g 2))
        (test(eq ?w 1))
        (test(eq ?s1 2))
		(test(eq ?s2 1))
        => 
        (assert (UI-control (id 1)(message "disease 1")))
       ; (printout t "disease 1" crlf)
)

(defrule disease-2
        (preference (gender ?g)(age 1)(weight ?w)(fever y)(symptom1 ?s1)(symptom2 ?s2))        
        (test(eq ?g 2))
        (test(eq ?w 2))
        (test(eq ?s1 3))
		(test(eq ?s2 2))
        => 
        (assert (UI-control (id 1)(message "disease 2")))
        ;(printout t "disease 2" crlf)
)
(defrule disease-3
        (preference (gender ?g)(age 2)(weight ?w)(fever y)(symptom1 ?s1)(symptom2 ?s2))        
        (test(eq ?g 1))
        (test(eq ?w 1))
        (test(eq ?s1 4))  
		(test(eq ?s2 3))
        => 
        (assert (UI-control (id 1)(message "disease 3")))
        ;(printout t "disease 3" crlf)
)
(defrule disease-4
        (preference (gender ?g)(age 1)(weight ?w)(fever y)(symptom1 ?s1)(symptom2 ?s2))        
        (test(eq ?g 2))
        (test(eq ?w 2))
        (test(eq ?s1 5)) 
		(test(eq ?s2 4)) 
        => 
        (assert (UI-control (id 1)(message "disease 4")))
        ;(printout t "disease 4" crlf)
)
(defrule disease-5
        (preference (gender ?g)(age 2)(weight ?w)(fever y)(symptom1 ?s1)(symptom2 ?s2))        
        (test(eq ?g 2))
        (test(eq ?w 1))
        (test(eq ?s1 5))
		(test(eq ?s2 5))
        => 
        (assert (UI-control (id 1)(message "disease 5")))
        ;(printout t "disease 5" crlf)        
 
)
