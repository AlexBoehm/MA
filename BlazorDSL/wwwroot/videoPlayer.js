// Definition des Custom Elements
class VideoPlayer extends HTMLElement {
    connectedCallback() {
    const shadow = this.attachShadow({ mode: 'open' });
        
    shadow.innerHTML = `
        <style>
        .video-container {
            width: 640px;
            height: 360px;
            background-color: #404040;
            border: 3px solid #000;
            box-sizing: border-box;
        }
        </style>
        <div class="video-container"></div>
    `;
    }
}
    
// Registrierung des Custom Elements
customElements.define('video-player', VideoPlayer);
