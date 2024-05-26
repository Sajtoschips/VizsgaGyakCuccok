import Axios from 'axios';
Axios.defaults.baseURL = 'http://localhost:3000';

export default {
    getAllWatches(page, search){
        return Axios.get(`/watches?_page=${page}&Model_like=${search}`)  
    },

    // kivalasztottGyartoAutoi(manufacturerid){
    //     return Axios.get(`/api/cars/${manufacturerid}`)
    // },
    // saveUser(user){
    //     return Axios.post('/users',user).then(()=>{});
    // },
    // updateUser(user,id){
    //     return Axios.put(`/users/${id}`,user).then(()=>{});
    // }


}