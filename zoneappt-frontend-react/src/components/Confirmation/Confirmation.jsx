import React from "react";
import styles from './Confirmation.module.css';

const Confirmation = ({day}) => {

    const dt = new Date();
    dt.setDate(day.day);
    dt.setMonth(day.month - 1);
    dt.setFullYear(day.year);
    const options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
    const prettyDay = dt.toLocaleDateString('en-us', options);

    return ( 
        <div className={styles.container}>
  <div>Thank you for your service request.</div>
  <div>Your service is scheduled for {prettyDay}</div>
 </div>
     );
}
 
export default Confirmation;