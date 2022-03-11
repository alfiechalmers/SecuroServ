const port = process.env.PORT || 2469;

const io = require("socket.io")(port);

console.log(`Server running on port ${port}`);


let clients = {};
io.on('connection', (socket) => {
    console.log(`New connection from ${socket.id}`);
    socket.emit("login-required");
    socket.on("login-event", (data) => {
        if (clients[socket.id]) return;
        console.log(`${socket.id} will now be known as ${data.name}`)
        clients[socket.id] = {
            name: data.name
        }
    })
    socket.on("message", (message) => {
        if (clients[socket.id]) {
            console.log(`${clients[socket.id].name}: ${message}`)
        } else {
            socket.emit("login-required")
        }
        
    })
    socket.on("disconnect", () => {
        console.log(`${clients[socket.id] ? clients[socket.id].name : socket.id} disconnected`)
    })
})