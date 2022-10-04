import React, {useState} from "react";
import styles from './Address.module.css';



const Address = ({submitAddress, setStreetAddress, setCity}) => {

    return(
       <form className={styles.container} onSubmit={(e) => submitAddress(e)}>
        <label className={styles.label}>What is your address?</label>
        <input className={styles.input} onChange={(e) => setStreetAddress(e.target.value)} required type='text'></input>
        <label className={styles.label}>What is your city?</label>
        <input className={styles.input} onChange={(e) => setCity(e.target.value)} required type='text'></input>
        <button className={styles.button} type='submit'>Find my zone</button>
       </form> 
    )
}

export default Address;