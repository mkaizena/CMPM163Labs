
uniform vec3 colorA;
uniform vec3 colorB;
uniform vec3 colorC;

varying vec3 vUv;

void main() {
	vec3 color = vec3(0);
	vec3 color1 = vec3(mix(color,colorA,vUv.x));
	vec3 color2 = vec3(mix(color1,colorB,vUv.y));
	vec3 color3 = vec3(mix(color2,colorC,vUv.z));

  	gl_FragColor = vec4(color3, 1.0);
}
