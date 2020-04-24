
uniform sampler2D texture2;
varying vec2 vUv;

void main() {
	vec4 txtbotleft  = texture2D(texture2,vUv/0.5);
	vec4 txttopright = texture2D(texture2,(vUv/0.5)-1.0);
	vec4 txttopleft  = texture2D(texture2, vec2(vUv.x/0.5,(vUv.y/0.5)-1.0));
	vec4 txtbotright = texture2D(texture2, vec2((vUv.x/0.5)-1.0,vUv.y/0.5));
	if(vUv.x < 0.5 && vUv.y > 0.5){
		gl_FragColor = txttopleft;
	}
	if(vUv.x < 0.5 && vUv.y < 0.5){
		gl_FragColor = txtbotleft;
	}
	if(vUv.x > 0.5  && vUv.y > 0.5){
		gl_FragColor = txttopright;
	}
	if(vUv.x > 0.5 && vUv.y < 0.5){
		gl_FragColor = txtbotright;
	}
}
