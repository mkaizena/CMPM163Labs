
varying vec3 vUv;

void main() {

  	gl_FragColor = vec4(vUv.x+0.1,vUv.x+0.4,vUv.x+0.8, 1.0);
}
