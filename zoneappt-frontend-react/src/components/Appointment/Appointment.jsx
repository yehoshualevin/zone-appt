import React, {useState, useEffect, useContext} from "react";
import AppointmentHeader from "../AppointmentHeader";
import Week from "../Week";
import styles from './Appointment.module.css';
import { useDate } from "../../hooks/useDate";


const Appointment = ({setDay}) => {

  const daysOfWeek = ['SUN', 'MON', 'TUE', 'WED', 'THU', 'FRI', 'SAT'];
  const [nav, setNav] = useState(0);
  const { weeks, my } = useDate(nav);

    return (
        <div className={styles.container}>
        <AppointmentHeader month={my} currentNav={nav} setMonth={setNav} />
        <table className={styles.table}>
              <thead>
            <tr>
              {daysOfWeek.map((d, i) => <th key={i}>{d}</th>)}
            </tr>
            </thead>
            <tbody>
              {weeks.map((w, index) => (
                <Week setDay={setDay} week={w} key={index}/>
              ))}
              </tbody>
            </table>
           
        </div>
    )
}

export default Appointment;