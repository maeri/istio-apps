1. Clean code -> moved yamls to yaml-files dir

2. Issue cmd: 

kubectl create namespace istio-apps

3. Enable auto inject 

kubectl label namespace istio-apps istio-injection=enabled

4.Describe to be sure , that it was injcted

kubectl describe ns

5. Apply

kubectl apply -f yaml-files/ -n istio-apps

6. Works