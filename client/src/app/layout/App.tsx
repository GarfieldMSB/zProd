import { useEffect, useState } from "react";
import {
  Box,
    Container,
    CssBaseline
} from "@mui/material";
import { NavBar } from "./NavBar";
import { ActivityDashboard } from "../../features/activities/dashboard/ActivityDashboard";

function App() {
    const [activities, setActivities] = useState<Activity[]>([]);

    useEffect(() => {
        fetch("https://localhost:5001/api/activities/")
            .then((response) => response.json())
            .then((activities) => setActivities(activities));

        return () => {};
    }, []);

    return (
        <Box sx={{bgcolor: '#eeeeee'}}>
            <CssBaseline />
            <NavBar />
            <Container maxWidth="xl" sx={{ mt: 3 }}>
                <ActivityDashboard activities={activities}/>
            </Container>
        </Box>
    );
}

export default App;
