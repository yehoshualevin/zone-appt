import React, {useState} from "react";
import styles from './Info.module.css';
import axios from 'axios';




const Info = ({day ,streetAddress, city, setCompleted }) => {


    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [cell, setCell] = useState('');
    const [email, setEmail] = useState('');
  

    
    const dt = new Date();
    dt.setDate(day.day);
    dt.setMonth(day.month - 1);
    dt.setFullYear(day.year);
    const options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
    const prettyDay = dt.toLocaleDateString('en-us', options);

    const base_url = process.env.NODE_ENV === 'development' ? 'https://localhost:7060' : 'https://qfbackend120220825152624.azurewebsites.net';


    const submitAddress = (e) => {
        e.preventDefault();


        if(firstName !== '' && lastName !== '' && cell !== '' && email !== ''){
          axios.post(base_url + '/api/Appt/', {
            firstName: firstName,
            lastName: lastName,
            address: streetAddress,
            city: city,
            cell: cell,
            email: email,
            apptDay: dt.toJSON()
          })
          .then(function (response) {
            setCompleted(true);
            console.log(response);
          })
          .catch(function (error) {
            console.log(error);
          });
        }
       
    }


    return(
      <form className={styles.container} onSubmit={(e) => submitAddress(e)}>
      <label className={styles.label}>First Name </label> 
      <input className={styles.input} onChange={(e) => setFirstName(e.target.value)} required type="text" />
      <label className={styles.label}>Last Name </label> 
      <input className={styles.input} onChange={(e) => setLastName(e.target.value)} required type="text" />
      <label className={styles.label}>Address </label> 
      <label className={styles.label}>{streetAddress}</label> 
      <label className={styles.label}>City </label> 
      <label className={styles.label}>{city}</label> 
      <label className={styles.label}>Cell </label> 
      <input className={styles.input} onChange={(e) => setCell(e.target.value)} required type="text" />
      <label className={styles.label}>Email </label>
      <input className={styles.input} onChange={(e) => setEmail(e.target.value)} required type="text" />
      <label className={styles.label}>Appt Day</label> 
      <label className={styles.label}>{prettyDay}</label>
      <button className={styles.button} type='submit'>Confirm</button> 
</form>
    )
}

export default Info;