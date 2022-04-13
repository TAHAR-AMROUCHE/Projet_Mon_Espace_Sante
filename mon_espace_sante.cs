using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Agenda
    public class Agenda
    {
        #region Member Variables
        protected int _Id_Agenda;
        protected int _Doc_id;
        protected int _Age_Pat;
        protected string _Sexe;
        protected string _email;
        protected string _Taille_Pat;
        protected string _Poids_Pat;
        protected string _Maladie_Pat;
        protected string _Alergie_Pat;
        protected string _Medicament_Pat;
        protected string _Medecin_Pat;
        #endregion
        #region Constructors
        public Agenda() { }
        public Agenda(int Doc_id, int Age_Pat, string Sexe, string email, string Taille_Pat, string Poids_Pat, string Maladie_Pat, string Alergie_Pat, string Medicament_Pat, string Medecin_Pat)
        {
            this._Doc_id=Doc_id;
            this._Age_Pat=Age_Pat;
            this._Sexe=Sexe;
            this._email=email;
            this._Taille_Pat=Taille_Pat;
            this._Poids_Pat=Poids_Pat;
            this._Maladie_Pat=Maladie_Pat;
            this._Alergie_Pat=Alergie_Pat;
            this._Medicament_Pat=Medicament_Pat;
            this._Medecin_Pat=Medecin_Pat;
        }
        #endregion
        #region Public Properties
        public virtual int Id_Agenda
        {
            get {return _Id_Agenda;}
            set {_Id_Agenda=value;}
        }
        public virtual int Doc_id
        {
            get {return _Doc_id;}
            set {_Doc_id=value;}
        }
        public virtual int Age_Pat
        {
            get {return _Age_Pat;}
            set {_Age_Pat=value;}
        }
        public virtual string Sexe
        {
            get {return _Sexe;}
            set {_Sexe=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Taille_Pat
        {
            get {return _Taille_Pat;}
            set {_Taille_Pat=value;}
        }
        public virtual string Poids_Pat
        {
            get {return _Poids_Pat;}
            set {_Poids_Pat=value;}
        }
        public virtual string Maladie_Pat
        {
            get {return _Maladie_Pat;}
            set {_Maladie_Pat=value;}
        }
        public virtual string Alergie_Pat
        {
            get {return _Alergie_Pat;}
            set {_Alergie_Pat=value;}
        }
        public virtual string Medicament_Pat
        {
            get {return _Medicament_Pat;}
            set {_Medicament_Pat=value;}
        }
        public virtual string Medecin_Pat
        {
            get {return _Medecin_Pat;}
            set {_Medecin_Pat=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Bloodgroup
    public class Bloodgroup
    {
        #region Member Variables
        protected int _bg_id;
        protected string _bg_name;
        #endregion
        #region Constructors
        public Bloodgroup() { }
        public Bloodgroup(string bg_name)
        {
            this._bg_name=bg_name;
        }
        #endregion
        #region Public Properties
        public virtual int Bg_id
        {
            get {return _bg_id;}
            set {_bg_id=value;}
        }
        public virtual string Bg_name
        {
            get {return _bg_name;}
            set {_bg_name=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Booking
    public class Booking
    {
        #region Member Variables
        protected int _booking_id;
        protected string _dname;
        protected int _userid;
        protected string _dcontact;
        protected string _expertise;
        protected string _fee;
        protected string _pname;
        protected string _pcontact;
        protected string _email;
        protected string _address;
        protected unknown _dates;
        protected string _tyme;
        protected string _payment;
        #endregion
        #region Constructors
        public Booking() { }
        public Booking(string dname, int userid, string dcontact, string expertise, string fee, string pname, string pcontact, string email, string address, unknown dates, string tyme, string payment)
        {
            this._dname=dname;
            this._userid=userid;
            this._dcontact=dcontact;
            this._expertise=expertise;
            this._fee=fee;
            this._pname=pname;
            this._pcontact=pcontact;
            this._email=email;
            this._address=address;
            this._dates=dates;
            this._tyme=tyme;
            this._payment=payment;
        }
        #endregion
        #region Public Properties
        public virtual int Booking_id
        {
            get {return _booking_id;}
            set {_booking_id=value;}
        }
        public virtual string Dname
        {
            get {return _dname;}
            set {_dname=value;}
        }
        public virtual int Userid
        {
            get {return _userid;}
            set {_userid=value;}
        }
        public virtual string Dcontact
        {
            get {return _dcontact;}
            set {_dcontact=value;}
        }
        public virtual string Expertise
        {
            get {return _expertise;}
            set {_expertise=value;}
        }
        public virtual string Fee
        {
            get {return _fee;}
            set {_fee=value;}
        }
        public virtual string Pname
        {
            get {return _pname;}
            set {_pname=value;}
        }
        public virtual string Pcontact
        {
            get {return _pcontact;}
            set {_pcontact=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Address
        {
            get {return _address;}
            set {_address=value;}
        }
        public virtual unknown Dates
        {
            get {return _dates;}
            set {_dates=value;}
        }
        public virtual string Tyme
        {
            get {return _tyme;}
            set {_tyme=value;}
        }
        public virtual string Payment
        {
            get {return _payment;}
            set {_payment=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Category
    public class Category
    {
        #region Member Variables
        protected int _id;
        protected string _cat;
        #endregion
        #region Constructors
        public Category() { }
        public Category(string cat)
        {
            this._cat=cat;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Cat
        {
            get {return _cat;}
            set {_cat=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Consultation
    public class Consultation
    {
        #region Member Variables
        protected int _Id_con;
        protected int _Id_Pat;
        protected unknown _Date_Cons;
        protected int _Type_Cons;
        protected unknown _Heure;
        protected string _poids;
        protected unknown _Prix;
        protected string _Observation;
        #endregion
        #region Constructors
        public Consultation() { }
        public Consultation(int Id_Pat, unknown Date_Cons, int Type_Cons, unknown Heure, string poids, unknown Prix, string Observation)
        {
            this._Id_Pat=Id_Pat;
            this._Date_Cons=Date_Cons;
            this._Type_Cons=Type_Cons;
            this._Heure=Heure;
            this._poids=poids;
            this._Prix=Prix;
            this._Observation=Observation;
        }
        #endregion
        #region Public Properties
        public virtual int Id_con
        {
            get {return _Id_con;}
            set {_Id_con=value;}
        }
        public virtual int Id_Pat
        {
            get {return _Id_Pat;}
            set {_Id_Pat=value;}
        }
        public virtual unknown Date_Cons
        {
            get {return _Date_Cons;}
            set {_Date_Cons=value;}
        }
        public virtual int Type_Cons
        {
            get {return _Type_Cons;}
            set {_Type_Cons=value;}
        }
        public virtual unknown Heure
        {
            get {return _Heure;}
            set {_Heure=value;}
        }
        public virtual string Poids
        {
            get {return _poids;}
            set {_poids=value;}
        }
        public virtual unknown Prix
        {
            get {return _Prix;}
            set {_Prix=value;}
        }
        public virtual string Observation
        {
            get {return _Observation;}
            set {_Observation=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Contact
    public class Contact
    {
        #region Member Variables
        protected int _contact_id;
        protected string _firstname;
        protected string _lastname;
        protected string _email;
        protected string _comment;
        #endregion
        #region Constructors
        public Contact() { }
        public Contact(string firstname, string lastname, string email, string comment)
        {
            this._firstname=firstname;
            this._lastname=lastname;
            this._email=email;
            this._comment=comment;
        }
        #endregion
        #region Public Properties
        public virtual int Contact_id
        {
            get {return _contact_id;}
            set {_contact_id=value;}
        }
        public virtual string Firstname
        {
            get {return _firstname;}
            set {_firstname=value;}
        }
        public virtual string Lastname
        {
            get {return _lastname;}
            set {_lastname=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Comment
        {
            get {return _comment;}
            set {_comment=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Doctor
    public class Doctor
    {
        #region Member Variables
        protected int _doc_id;
        protected string _doctor_id;
        protected string _name;
        protected string _address;
        protected string _contact;
        protected string _email;
        protected string _expertise;
        protected int _id;
        protected string _fee;
        protected string _userid;
        protected string _password;
        protected string _pic;
        #endregion
        #region Constructors
        public Doctor() { }
        public Doctor(string doctor_id, string name, string address, string contact, string email, string expertise, int id, string fee, string userid, string password, string pic)
        {
            this._doctor_id=doctor_id;
            this._name=name;
            this._address=address;
            this._contact=contact;
            this._email=email;
            this._expertise=expertise;
            this._id=id;
            this._fee=fee;
            this._userid=userid;
            this._password=password;
            this._pic=pic;
        }
        #endregion
        #region Public Properties
        public virtual int Doc_id
        {
            get {return _doc_id;}
            set {_doc_id=value;}
        }
        public virtual string Doctor_id
        {
            get {return _doctor_id;}
            set {_doctor_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Address
        {
            get {return _address;}
            set {_address=value;}
        }
        public virtual string Contact
        {
            get {return _contact;}
            set {_contact=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Expertise
        {
            get {return _expertise;}
            set {_expertise=value;}
        }
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Fee
        {
            get {return _fee;}
            set {_fee=value;}
        }
        public virtual string Userid
        {
            get {return _userid;}
            set {_userid=value;}
        }
        public virtual string Password
        {
            get {return _password;}
            set {_password=value;}
        }
        public virtual string Pic
        {
            get {return _pic;}
            set {_pic=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Donation
    public class Donation
    {
        #region Member Variables
        protected int _donation_id;
        protected string _name;
        protected string _address;
        protected string _unit;
        protected unknown _dates;
        protected string _email;
        #endregion
        #region Constructors
        public Donation() { }
        public Donation(string name, string address, string unit, unknown dates, string email)
        {
            this._name=name;
            this._address=address;
            this._unit=unit;
            this._dates=dates;
            this._email=email;
        }
        #endregion
        #region Public Properties
        public virtual int Donation_id
        {
            get {return _donation_id;}
            set {_donation_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Address
        {
            get {return _address;}
            set {_address=value;}
        }
        public virtual string Unit
        {
            get {return _unit;}
            set {_unit=value;}
        }
        public virtual unknown Dates
        {
            get {return _dates;}
            set {_dates=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Feedback
    public class Feedback
    {
        #region Member Variables
        protected int _id;
        protected string _email;
        protected string _feedback;
        #endregion
        #region Constructors
        public Feedback() { }
        public Feedback(string email, string feedback)
        {
            this._email=email;
            this._feedback=feedback;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Feedback
        {
            get {return _feedback;}
            set {_feedback=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Medicament
    public class Medicament
    {
        #region Member Variables
        protected int _Id_Med;
        protected string _Nom_Med;
        protected string _Commentaire;
        protected unknown _Date_Ce;
        #endregion
        #region Constructors
        public Medicament() { }
        public Medicament(string Nom_Med, string Commentaire, unknown Date_Ce)
        {
            this._Nom_Med=Nom_Med;
            this._Commentaire=Commentaire;
            this._Date_Ce=Date_Ce;
        }
        #endregion
        #region Public Properties
        public virtual int Id_Med
        {
            get {return _Id_Med;}
            set {_Id_Med=value;}
        }
        public virtual string Nom_Med
        {
            get {return _Nom_Med;}
            set {_Nom_Med=value;}
        }
        public virtual string Commentaire
        {
            get {return _Commentaire;}
            set {_Commentaire=value;}
        }
        public virtual unknown Date_Ce
        {
            get {return _Date_Ce;}
            set {_Date_Ce=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Ordonnance
    public class Ordonnance
    {
        #region Member Variables
        protected int _Id_ord;
        protected int _Doc_id;
        protected string _Medicament_Pat;
        protected unknown _Date_Ord;
        protected string _Observation;
        protected string _Nom_Med;
        protected string _Nom_Pat;
        protected int _Contact_Pat;
        protected int _Age_Pat;
        protected int _Contact_Med;
        protected string _email_Pat;
        #endregion
        #region Constructors
        public Ordonnance() { }
        public Ordonnance(int Doc_id, string Medicament_Pat, unknown Date_Ord, string Observation, string Nom_Med, string Nom_Pat, int Contact_Pat, int Age_Pat, int Contact_Med, string email_Pat)
        {
            this._Doc_id=Doc_id;
            this._Medicament_Pat=Medicament_Pat;
            this._Date_Ord=Date_Ord;
            this._Observation=Observation;
            this._Nom_Med=Nom_Med;
            this._Nom_Pat=Nom_Pat;
            this._Contact_Pat=Contact_Pat;
            this._Age_Pat=Age_Pat;
            this._Contact_Med=Contact_Med;
            this._email_Pat=email_Pat;
        }
        #endregion
        #region Public Properties
        public virtual int Id_ord
        {
            get {return _Id_ord;}
            set {_Id_ord=value;}
        }
        public virtual int Doc_id
        {
            get {return _Doc_id;}
            set {_Doc_id=value;}
        }
        public virtual string Medicament_Pat
        {
            get {return _Medicament_Pat;}
            set {_Medicament_Pat=value;}
        }
        public virtual unknown Date_Ord
        {
            get {return _Date_Ord;}
            set {_Date_Ord=value;}
        }
        public virtual string Observation
        {
            get {return _Observation;}
            set {_Observation=value;}
        }
        public virtual string Nom_Med
        {
            get {return _Nom_Med;}
            set {_Nom_Med=value;}
        }
        public virtual string Nom_Pat
        {
            get {return _Nom_Pat;}
            set {_Nom_Pat=value;}
        }
        public virtual int Contact_Pat
        {
            get {return _Contact_Pat;}
            set {_Contact_Pat=value;}
        }
        public virtual int Age_Pat
        {
            get {return _Age_Pat;}
            set {_Age_Pat=value;}
        }
        public virtual int Contact_Med
        {
            get {return _Contact_Med;}
            set {_Contact_Med=value;}
        }
        public virtual string Email_Pat
        {
            get {return _email_Pat;}
            set {_email_Pat=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Patient
    public class Patient
    {
        #region Member Variables
        protected int _Id_pat;
        protected string _NIR;
        protected string _Nom_Pat;
        protected string _Prenom_Pat;
        protected int _Age_Pat;
        protected string _Telephone;
        protected string _email;
        protected string _Adresse;
        protected string _Sexe;
        protected string _Mdp;
        #endregion
        #region Constructors
        public Patient() { }
        public Patient(string NIR, string Nom_Pat, string Prenom_Pat, int Age_Pat, string Telephone, string email, string Adresse, string Sexe, string Mdp)
        {
            this._NIR=NIR;
            this._Nom_Pat=Nom_Pat;
            this._Prenom_Pat=Prenom_Pat;
            this._Age_Pat=Age_Pat;
            this._Telephone=Telephone;
            this._email=email;
            this._Adresse=Adresse;
            this._Sexe=Sexe;
            this._Mdp=Mdp;
        }
        #endregion
        #region Public Properties
        public virtual int Id_pat
        {
            get {return _Id_pat;}
            set {_Id_pat=value;}
        }
        public virtual string NIR
        {
            get {return _NIR;}
            set {_NIR=value;}
        }
        public virtual string Nom_Pat
        {
            get {return _Nom_Pat;}
            set {_Nom_Pat=value;}
        }
        public virtual string Prenom_Pat
        {
            get {return _Prenom_Pat;}
            set {_Prenom_Pat=value;}
        }
        public virtual int Age_Pat
        {
            get {return _Age_Pat;}
            set {_Age_Pat=value;}
        }
        public virtual string Telephone
        {
            get {return _Telephone;}
            set {_Telephone=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Adresse
        {
            get {return _Adresse;}
            set {_Adresse=value;}
        }
        public virtual string Sexe
        {
            get {return _Sexe;}
            set {_Sexe=value;}
        }
        public virtual string Mdp
        {
            get {return _Mdp;}
            set {_Mdp=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Registration
    public class Registration
    {
        #region Member Variables
        protected int _donar_id;
        protected string _username;
        protected string _gender;
        protected string _age;
        protected string _contact;
        protected string _type;
        protected string _city;
        protected string _address;
        protected string _bgroup;
        protected unknown _dates;
        protected string _email;
        protected int _password;
        protected string _pic;
        #endregion
        #region Constructors
        public Registration() { }
        public Registration(string username, string gender, string age, string contact, string type, string city, string address, string bgroup, unknown dates, string email, int password, string pic)
        {
            this._username=username;
            this._gender=gender;
            this._age=age;
            this._contact=contact;
            this._type=type;
            this._city=city;
            this._address=address;
            this._bgroup=bgroup;
            this._dates=dates;
            this._email=email;
            this._password=password;
            this._pic=pic;
        }
        #endregion
        #region Public Properties
        public virtual int Donar_id
        {
            get {return _donar_id;}
            set {_donar_id=value;}
        }
        public virtual string Username
        {
            get {return _username;}
            set {_username=value;}
        }
        public virtual string Gender
        {
            get {return _gender;}
            set {_gender=value;}
        }
        public virtual string Age
        {
            get {return _age;}
            set {_age=value;}
        }
        public virtual string Contact
        {
            get {return _contact;}
            set {_contact=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        public virtual string City
        {
            get {return _city;}
            set {_city=value;}
        }
        public virtual string Address
        {
            get {return _address;}
            set {_address=value;}
        }
        public virtual string Bgroup
        {
            get {return _bgroup;}
            set {_bgroup=value;}
        }
        public virtual unknown Dates
        {
            get {return _dates;}
            set {_dates=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual int Password
        {
            get {return _password;}
            set {_password=value;}
        }
        public virtual string Pic
        {
            get {return _pic;}
            set {_pic=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Requestes
    public class Requestes
    {
        #region Member Variables
        protected int _reg_id;
        protected string _name;
        protected string _gender;
        protected int _age;
        protected string _mobile;
        protected string _bgroup;
        protected string _email;
        protected unknown _reqdate;
        protected string _detail;
        #endregion
        #region Constructors
        public Requestes() { }
        public Requestes(string name, string gender, int age, string mobile, string bgroup, string email, unknown reqdate, string detail)
        {
            this._name=name;
            this._gender=gender;
            this._age=age;
            this._mobile=mobile;
            this._bgroup=bgroup;
            this._email=email;
            this._reqdate=reqdate;
            this._detail=detail;
        }
        #endregion
        #region Public Properties
        public virtual int Reg_id
        {
            get {return _reg_id;}
            set {_reg_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Gender
        {
            get {return _gender;}
            set {_gender=value;}
        }
        public virtual int Age
        {
            get {return _age;}
            set {_age=value;}
        }
        public virtual string Mobile
        {
            get {return _mobile;}
            set {_mobile=value;}
        }
        public virtual string Bgroup
        {
            get {return _bgroup;}
            set {_bgroup=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual unknown Reqdate
        {
            get {return _reqdate;}
            set {_reqdate=value;}
        }
        public virtual string Detail
        {
            get {return _detail;}
            set {_detail=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mon_espace_sante
{
    #region Users
    public class Users
    {
        #region Member Variables
        protected string _id_admin;
        protected string _mdp_admin;
        protected string _type;
        protected string _email;
        #endregion
        #region Constructors
        public Users() { }
        public Users(string id_admin, string mdp_admin, string type, string email)
        {
            this._id_admin=id_admin;
            this._mdp_admin=mdp_admin;
            this._type=type;
            this._email=email;
        }
        #endregion
        #region Public Properties
        public virtual string Id_admin
        {
            get {return _id_admin;}
            set {_id_admin=value;}
        }
        public virtual string Mdp_admin
        {
            get {return _mdp_admin;}
            set {_mdp_admin=value;}
        }
        public virtual string Type
        {
            get {return _type;}
            set {_type=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        #endregion
    }
    #endregion
}