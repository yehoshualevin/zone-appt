import React from "react";
import Day from "../Day";
import styles from './Week.module.css';

const Week = ({week, setDay}) => {

    return(
        <tr>{week.map((d ,index) => 
            <Day setDay={setDay} day={d} key={index} />
            )}</tr>
    )
}

export default Week;