import React, {useState, createContext} from 'react';
import Address from './components/Address';
import Appointment from './components/Appointment';
import Info from './components/Info';
import Confirmation from './components/Confirmation';
import './App.css';



const ZoneContext = createContext();

function App() {

  const [streetAddress, setStreetAddress] = useState('');
  const [city, setCity] = useState('');
  const [zone, setZone] = useState(0);
  const [day, setDay] = useState();
  const [completed, setCompleted] = useState(false);

  const base_url = process.env.NODE_ENV === 'development' ? 'https://localhost:7060' : 'https://qfbackend120220825152624.azurewebsites.net';

  const submitAddress = (e) => {
    e.preventDefault();
      if(streetAddress !== '' && city !== ''){
    const fullAddress = streetAddress + ' ' + city;
    console.log(base_url);
    const query = base_url + '/api/Zone/?address=' + fullAddress;
    console.log(query);
    fetch(query)
    .then((response) => response.json())
    .then((data)=>{ setZone(data.zoneNumber)});
    }
}

  return (
    <ZoneContext.Provider value={zone}>
    <div className='wrapper'> 
    {zone === 0 && <Address setStreetAddress={setStreetAddress} setCity={setCity} submitAddress={submitAddress}/>}
    {zone > 0 && !day && <Appointment setDay={setDay}/>}  
    {day && !completed && <Info day={day} streetAddress={streetAddress} city={city} setCompleted={setCompleted}/>}
    {day && completed && <Confirmation day={day}/>}
    </div>
    </ZoneContext.Provider>
  );
}


export default App;
export {ZoneContext};
