# orologioSQLite

Η εφαρμογή αναπτύχθηκε με σκοπό να μπορέσει να εξυπηρετήσει κηδεμόνες, γονείς και εκπαιδευτικούς που ενδιαφέρονται να έχουν πρόσβαση στο ωρολόγιο πρόγραμμα του σχολείου από το κινητό τους τηλέφωνο (Windows Phone 8.1 και νεώτερο). Η συγκεκριμένη έκδοση αποτελεί τη συνέχεια της εφαρμογής orologioJSON η οποία υπάρχει και αυτή διαθέσιμη στο GitHub.    


Τα δεδομένα του ωρολογίου προγράμματος, περιέχονται πλέον σε ένα αρχείο βάσης δεδομένων SQLite , το οποίο και δημιουργείται με τη χρήση της εφαρμογής orologioDesktop.  Εκτενής περιγραφή των παραμέτρων του αρχείου της SQLite μπορεί κανείς να δει στο αντίστοιχο αρχείο README.md της εφαρμογής orologioDesktop. 

Στον φάκελο Assets/Daskaloi μπορούν να τοποθετηθούν φωτογραφίες του εκπαιδευτικού προσωπικού ώστε να προβάλλονται και οι φωτογραφίες του διδακτικού προσωπικού ενώ τροποποιώντας το αρχείο Package.appxmanifest μπορούν να τροποποιηθούν και άλλα στοιχεία του προγράμματος (splash screens , όνομα προγράμματος κλπ).

Προφανώς και σε κάθε περίπτωση θα πρέπει να έχει ο κάθε ενδιαφερόμενος υπόψη του τα εξής: 1. Απαιτείται compile της εφαρμογής μέσω του Visual Studio το οποίο πρέπει να περιλαμβάνει και τα Windows Phone εργαλεία. Υπάρχουν οι δωρεάν εκδόσεις του Visual Studio που εξυπηρετούν. 2. Για εγκατάσταση σε ένα – δύο κινητά , αρκεί αυτά να ξεκλειδωθούν από το Visual Studio και να εγκατασταθεί η εφαρμογή μέσω USB. Για την περίπτωση όμως που κάποιο σχολείο ενδιαφέρεται να κάνει διαθέσιμο το πρόγραμμα μέσω του Windows Application Store θα πρέπει να γίνουν όλα όσα απαιτούνται για τη δημοσίευση εφαρμογών στο Windows Store. Πληροφορίες υπάρχουν στο site της Microsoft (https://developer.microsoft.com/en-us/windows/publish )

Αποτελεί την προτεινόμενη εφαρμογή για όσους επιθυμούν να έχουν πρόσβαση στο πρόγραμμα του σχολείου τους, από το κινητό τους τηλέφωνο.

Η εφαρμογή απαιτεί για τη λειτουργία της το αρχείο daskaloi.db το οποίο δημιουργείται από την εφαρμογή orologioDesktop και τοποθετείται στον φάκελο του project, μαζί με τα άλλα αρχεία (υπάρχει ήδη ένα δείγμα αρχείου daskaloi.db στον φάκελο, για άμεσο πειραματισμό). 

Άδεια (GPL v3.0 του FSF).

Ελπίζω έστω και ένας συνάδελφος ή γονιός να επωφεληθεί. 

Δημιουργός : Κωνσταντίνος Χερτούρας 
Διπλωματούχος Σχολής ΗΜΜΥ, Πολυτεχνείο Κρήτης, 1998
 MSc ECE , Imperial College , London, 1999 
 MSc Πληροφορική, τμ. ΗΜΜΥ , Πολυτεχνική Σχολή , ΑΠΘ, 2005 Εκπαιδευτικός Β’Θμιας Εκπαίδευσης , ΕΠΑΛ Ροδόπολης Σερρών

  
Ευχαριστίες: Ευχαριστώ τους καλούς μου φίλους και συμφοιτητές στο Πολυτεχνείο Κρήτης, Βλάσιο Τσιάτση (MSEE, PhD Electrical Engineering, UC Los Angeles) και Γιάννη Γεωργιάδη (PhD Computer Science, Imperial College, London) για τις πολύτιμες παρατηρήσεις τους. 
