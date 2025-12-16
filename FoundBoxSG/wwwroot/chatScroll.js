window.chatScroll = {
    scrollToBottom: function (container) {
        if (!container) return;
        container.scrollTop = container.scrollHeight;
    }
};
