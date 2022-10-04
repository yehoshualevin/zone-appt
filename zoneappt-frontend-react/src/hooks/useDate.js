import React, { useEffect, useState } from 'react';

export const useDate = (nav) => {

 const [my, setMy] = useState('');
 const [weeks, setWeeks] = useState([]);



 useEffect(() => { 
    const weekdays = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
    const dt = new Date();

    if(nav !== 0){
      dt.setDate(1);
      dt.setMonth(dt.getMonth() + nav);
    }

    const day = dt.getDate();
    const month = dt.getMonth();
    const year = dt.getFullYear();
  
    const firstDayInMonth = new Date(year, month, 1);
    const daysInMonth = new Date(year, month + 1, 0).getDate();
    const dateString = firstDayInMonth.toLocaleDateString('en-us', {
      weekday: 'long',
      year: 'numeric',
      month: 'numeric',
      day: 'numeric'
    });
  
    setMy(`${dt.toLocaleDateString('en-us', {month: 'long'})} ${year}`);
    const paddingDays = weekdays.indexOf(dateString.split(', ')[0]);
  
    const weeksArr = [];
    let daysArr = [];
  
    const totalDays = paddingDays + daysInMonth;
    for(let i = 1; i <= totalDays; i++){
      const dayOfWeek = i % 7; // sunday 1, monday 2, friday 6, saturday 0
      if(i > paddingDays){
        daysArr.push({
          month: month + 1, // humans are 1 based so need to add one
          day: i - paddingDays,
          year: year,
          isCurrentDay: month === 0 && i - paddingDays === day,
          dayOfWeek: dayOfWeek
        });
      } else {
        daysArr.push({
          month: '',
          day: 'padding',
          year: '',
          isCurrentDay: false,
          dayOfWeek: dayOfWeek
        });
      }
      if(dayOfWeek === 0 || i === totalDays){
        weeksArr.push(daysArr);
        daysArr = [];
      }
    }
    setWeeks(weeksArr);
  
  }, [nav]);

  return {
    weeks,
    my,
  };
};