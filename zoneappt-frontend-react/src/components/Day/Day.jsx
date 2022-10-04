import React, {useContext} from "react";
import styles from './Day.module.css';
import {ZoneContext} from '../../App';

const Day = ({day, setDay}) => {

let zone = useContext(ZoneContext);
zone += 1;
const paddingClass = day.day === 'padding' ? styles.padding : '';
const dtToday = new Date();
const today = day.day === dtToday.getDate() && day.month === dtToday.getMonth() + 1  && day.year === dtToday.getFullYear();
const dtThisDay = new Date();
dtThisDay.setDate(day.day);
dtThisDay.setMonth(day.month - 1);
dtThisDay.setFullYear(day.year);
const isOpen = day.dayOfWeek === zone && dtThisDay >= dtToday;
const openClass = isOpen ? styles.openday : '';

    return(
        <td className='day'>
                       <button className={`${styles.daybutton} ${paddingClass} ${openClass}`} disabled={!isOpen} onClick={() => setDay(day)}>
                        <span>{day.day === 'padding' ? '' : day.day}</span>{today && <div className={styles.today} ></div>}
                        </button>
                       
                  </td>
    )
}

export default Day;