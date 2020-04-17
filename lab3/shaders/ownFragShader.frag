
uniform vec3 colorA;
uniform vec3 colorB;
uniform vec3 colorC;

varying vec3 vUv;

void main() {
	vec3 color = vec3(mix(colorA,colorB,vUv.y));
	vec3 color2 = vec3(mix(color,colorC,vUv.z));
  	gl_FragColor = vec4(color2, 1.0);
}
