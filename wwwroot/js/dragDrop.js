window.dragDropHelper = {
    dragStart: function (event, taskId) {
        console.log("Dragging task ID:", taskId);
        event.dataTransfer.setData("text/plain", taskId);
    },
    allowDrop: function (event) {
        event.preventDefault(); // Allow dropping
    },
    drop: function (event) {
        event.preventDefault();
        const id = event.dataTransfer.getData("text/plain");
        console.log("Dropped task ID:", id);
        return id;
    }
};
