import { useEffect, useState } from 'react'
import './App.css'
import { List, ListItem, ListItemText, Typography } from '@mui/material';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]); 

  useEffect(() => {
    fetch('https://localhost:5001/api/activities/')
      .then((response) => response.json())
      .then(activities => setActivities(activities));

      return () => {};
  }, []);

  return (
    <>
      <Typography variant='h3'>Activities</Typography>
      <List>
          {
            activities.map(activity => (
              <ListItem key={activity.id}>
                <ListItemText>{activity.title}</ListItemText>
              </ListItem>
            ))
          }
      </List>
    </>
  )
}

export default App
