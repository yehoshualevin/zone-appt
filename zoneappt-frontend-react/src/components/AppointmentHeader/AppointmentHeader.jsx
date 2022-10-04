import React from "react";
import styles from './AppointmentHeader.module.css';

const AppointmentHeader = ({month, currentNav ,setMonth}) => {
    return ( 
 <div className={styles.container}>
    <h3 className={styles.my}>{month}</h3>
    <div>
        <button className={styles.arrow} onClick={() => setMonth(currentNav - 1)}><span className={styles.back}></span></button>
        <button className={styles.arrow} onClick={() => setMonth(currentNav + 1)}><span className={styles.next}></span></button>
    </div>
</div>
     );
}
 
export default AppointmentHeader;